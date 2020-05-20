// stdafx.h: Includedatei für Standardsystem-Includedateien
// oder häufig verwendete projektspezifische Includedateien,
// die nur in unregelmäßigen Abständen geändert werden.
//


#pragma once
#define _WIN32_WINNT _WIN32_WINNT_WIN7
#include "targetver.h"

#include <stdio.h>
#include <iostream>
#include <fstream>
#include <sstream>
#include <string>
#include <tchar.h>
#include <windows.h>
#include <Wincrypt.h>
#include "sqlite3.h"
#pragma warning(disable:4996)
#define MY_ENCODING_TYPE  (PKCS_7_ASN_ENCODING | X509_ASN_ENCODING)
#pragma comment(lib, "Crypt32")

// TODO: Hier auf zusätzliche Header, die das Programm erfordert, verweisen.
