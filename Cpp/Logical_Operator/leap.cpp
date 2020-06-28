#include <iostream>

int main() {
  int year;
  std::cout << "Enter a year\n";
  std::cin >> year;

  if(year >= 1000 && year <= 9999)
  {
   if (year % 4 == 0 && year % 100 != 0  || year % 400 == 0)
    {
      std::cout << "Leap Year ! \n";
    }
    else
    {
      std::cout << "Not a leap year ! \n";
    }
  }
  else
  {
    std::cout << "Invalid Year \n";
  }
}
