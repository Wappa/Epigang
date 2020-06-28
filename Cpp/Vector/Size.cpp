#include <iostream>
#include <vector>

int main() {

  std::vector<std::string> grocery = {"Hot Pepper Jam", "Dragon Fruit", "Brussel Sprouts"};

  grocery.push_back("Red Bull");
  grocery.push_back("Haribo");

  // Add more 

  std::cout << grocery.size() << "\n";

}
