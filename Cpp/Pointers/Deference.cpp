#include <iostream>

int main() {

  int power = 9000;

  // Create pointer
  int* ptr = &power;

  int *ptdr = ptr ;

  // Print ptr
  std::cout << ptr << "\n";

  // Print *ptr

  std::cout << *ptr << "\n";
}
