#include "stdafx.h"
#include "rebiz.h"
#include <string>
#include <iostream>
 
//#include <conio.h>
//#include <tchar.h>
//#include <stdio.h>

//#include <boost/filesystem.hpp>
using namespace std;
 
int main(int argc, char **argv)
{
	//char* a[] = { "hello world", "liitdar" };
	//char** b = a;
	auto at=1;
	ls53c2zl=L'五';
	ls8003zl='ھ';
	//auto tsd = (char*)"0123456789";
	//cout << tsd[2]<<":"<< sizeof(tsd)<< endl;
	//w_char wt;
	//wt ="啊是分";
	wcout<<"АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"<<endl;
 wcout.imbue(locale("chs"));
   wcout << ls8003zl << " -> " << sizeof(ls8003zl) << endl;
    wcout << ls53c2zl << " -> " << sizeof(ls53c2zl) << endl;
  	system("pause");
	return 0;
} 