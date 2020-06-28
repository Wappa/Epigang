#include <iostream>

int main() {

  int weight;

  std::cout << "Enter your weight (in kg): \n";

  std::cin >> weight;

  int Destination;

  std::cout << "Enter your destination: \n";

  std::cin >> Destination ;

  switch(Destination)
  {
    case 1:
      weight = weight * 0.78;
      std::cout << weight << "\n";
      break;
    case 2:
      weight = weight * 0.39;
      std::cout << weight << "\n";
      break;
    case 3:
      weight = weight * 2.65;
      std::cout << weight << "\n";
      break;
    case 4:
      weight = weight * 1.17;
      std::cout << weight << "\n";
      break;
    case 5:
      weight = weight * 1.05;
      std::cout << weight << "\n";
      break;
    case 6:
      weight = weight * 1.23;
      std::cout << weight << "\n";
      break;

  }

}
