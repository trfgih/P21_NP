
#include <iostream>
using namespace std;
int main(int a)
{
	int znach;
	cin >> a;
	if (a == 1) znach = 1;
	else znach = a * main(a - 1);
	return znach;
}

