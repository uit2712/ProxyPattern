#pragma once
#include <string>

using namespace std;

class IInternet
{
public:
	virtual void ConnectTo(string serverHost) = 0;
};