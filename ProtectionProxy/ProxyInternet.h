#pragma once
#include "IInternet.h"
#include <vector>
#include <string>
#include <iostream>

using namespace std;

class ProxyInternet : public IInternet
{
protected:
	IInternet*				_internet;
	vector<string>			_lstBannedSites;
protected:
	ProxyInternet();
public:
	~ProxyInternet();

	static ProxyInternet& Instance();

	void SetInternet(IInternet* internet);
	void ConnectTo(string serverHost);
protected:
	void InitListBannedSites();
	bool IsSiteBanned(string serverHost);
};

