#include <iostream>

int main() {
  double tempf = 70;
  double tempc;
  tempc = (tempf - 32)/1.8;

  std::cout << "The temp is " << tempc << " degrees Celsius. \n";
}
