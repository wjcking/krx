#include "stdafx.h"
#include "rebiz.h"
#include <string>
#include <iostream>

//#include <conio.h>
//#include <tchar.h>
//#include <stdio.h>

//#include <boost/filesystem.hpp>
  
#include<windows.h>
#include <io.h>
#include <map>
#include <fstream>
#include <atlimage.h>
using namespace std;
 void  draw()
{
    // 获取一个可供画图的DC，我这里就直接用桌面算了
    HDC hdc = GetWindowDC(GetDesktopWindow());

    // 创建红色1像素宽度的实线画笔
    HPEN hpen1 = CreatePen(PS_SOLID, 1, RGB(255, 0, 0));
    // 创建绿色5像素宽度的破折画笔，如果你想创建其他种类的画笔请参阅MSDN
    HPEN hpen2 = CreatePen(PS_DASH, 5, RGB(0, 255, 0));
    // 创建一个实体蓝色画刷
    HBRUSH hbrush1 = CreateSolidBrush(RGB(0, 0, 255));
    // 创造一个透明的画刷，如果你想创建其他种类的画刷请参阅MSDN
    HBRUSH hbrush2 = (HBRUSH)GetStockObject(NULL_BRUSH);

    // 将hpen1和hbrush1选进HDC，并保存HDC原来的画笔和画刷
    HPEN hpen_old = (HPEN)SelectObject(hdc, hpen1);
    HBRUSH hbrush_old = (HBRUSH)SelectObject(hdc, hbrush1);

    // 在(40,30)处画一个宽200像素，高50像素的矩形
    Rectangle(hdc, 40, 30, 40 + 200, 30 + 50);

    // 换hpen1和hbrush1，然后在(40,100)处也画一个矩形，看看有何差别
    SelectObject(hdc, hpen2);
    SelectObject(hdc, hbrush2);
    Rectangle(hdc, 40, 100, 40 + 200, 100 + 50);

    // 画个椭圆看看
    Ellipse(hdc, 40, 200, 40 + 200, 200 + 50);
        Sleep(10);
	draw();
 }
 
void CenterText(HDC hDC, int x, int y, LPCTSTR szFace, LPCTSTR szMessage, int point)
{
 HFONT hFont = CreateFont(- point * GetDeviceCaps(hDC, LOGPIXELSY) / 72,
  0, 0, 0, FW_BOLD, TRUE, FALSE, FALSE, 
  ANSI_CHARSET, OUT_TT_PRECIS, CLIP_DEFAULT_PRECIS, 
  PROOF_QUALITY, VARIABLE_PITCH, szFace);
 //  assert(hFont);
 
 HGDIOBJ hOld = SelectObject(hDC, hFont);
 
 SetTextAlign(hDC, TA_CENTER | TA_BASELINE);
 
 SetBkMode(hDC, TRANSPARENT);
 SetTextColor(hDC, RGB(0, 0, 0xFF));
 TextOut(hDC, x, y, szMessage, _tcslen(szMessage));
 
 SelectObject(hDC, hOld);
 DeleteObject(hFont);
}
 
const TCHAR szMessage[] = _T("Hello, World");
const TCHAR szFace[]    = _T("Times New Roman");
 
#pragma comment(linker, "-merge:.rdata=.text")

int main(int argc, char **argv)
{
	//char* a[] = { "hello world", "liitdar" };
	//char** b = a;
	// L'哀' unicode编码  没有L是ascii编码
	//auto at=1;
	//ket ket1 = '是';
	// cout<<ket1<<endl;
	//ls53c2zl=L'五';
	//ls8003zl='ھ';
	////auto tsd = (char*)"0123456789";
	////cout << tsd[2]<<":"<< sizeof(tsd)<< endl;
	////w_char wt;
	////wt ="啊是分";	
	//wcout<<"АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"<<endl;
	//wcout.imbue(locale("chs"));

	//wcout << ls8003zl << " -> " << sizeof(ls8003zl) << endl;
	//wcout << ls53c2zl << " -> " << sizeof(ls53c2zl) << endl;
 
     // draw();
 
	  HDC hDC = GetDC(NULL);
 //  assert(hDC);
 
 CenterText(hDC, GetSystemMetrics(SM_CXSCREEN) / 2,
  GetSystemMetrics(SM_CYSCREEN) / 2,
  szFace, szMessage, 72);
 
 ReleaseDC(NULL, hDC);
 ExitProcess(0);

	//system("pause");
	return 0;
} 