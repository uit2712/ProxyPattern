#pragma once
#include "IInternet.h"
#include <iostream>

class RealInternet : public IInternet
{
public:
	RealInternet();
	~RealInternet();

	void ConnectTo(string serverHost);
};