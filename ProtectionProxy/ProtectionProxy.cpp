#include "pch.h"
#include <iostream>
#include "ProxyInternet.h"
#include "RealInternet.h"

int main()
{
	IInternet* internet = new RealInternet();
	ProxyInternet::Instance().SetInternet(internet);
	ProxyInternet::Instance().ConnectTo("google.com");
	ProxyInternet::Instance().ConnectTo("mp3.zing.vn");
}