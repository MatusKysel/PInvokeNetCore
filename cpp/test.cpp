#include <iostream>
#include <string>

extern "C" {
	void print(const char* msg)
	{
		std::cout << std::string(msg) << std::endl;
	}
}
