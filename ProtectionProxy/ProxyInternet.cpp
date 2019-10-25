#include "pch.h"
#include "ProxyInternet.h"

ProxyInternet::ProxyInternet()
{
	InitListBannedSites();
}

ProxyInternet::~ProxyInternet()
{
	if (_internet)
	{
		delete _internet;
		_internet = nullptr;
	}

	if (_lstBannedSites.size() > 0)
		_lstBannedSites.clear();
}

ProxyInternet& ProxyInternet::Instance()
{
	static ProxyInternet instance;
	return instance;
}

void ProxyInternet::SetInternet(IInternet* internet)
{
	_internet = internet;
}

void ProxyInternet::InitListBannedSites()
{
	_lstBannedSites.push_back("google.com");
	_lstBannedSites.push_back("youtube.com");
	_lstBannedSites.push_back("facebook.com");
}

bool ProxyInternet::IsSiteBanned(string serverHost)
{
	for (unsigned int i = 0; i < _lstBannedSites.size(); i++)
		if (_lstBannedSites[i] == serverHost)
			return true;

	return false;
}

void ProxyInternet::ConnectTo(string serverHost)
{
	if (IsSiteBanned(serverHost))
		cout << serverHost << " is banned" << endl;
	else
	{
		if (_internet)
			_internet->ConnectTo(serverHost);
	}
}