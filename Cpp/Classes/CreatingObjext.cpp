=====music.cpp=====
#include <iostream>
#include "song.hpp"

int main() {

  Song electric_relaxation;
  electric_relaxation.add_title("Electric Relaxation");
  electric_relaxation.get_title();

  std::cout << electric_relaxation.get_title() << "\n";
}
=====Song.hpp=====
#include <string>

// add the Song class here:
class Song {

  std::string title;

public:
  void add_title(std::string new_title);
  std::string get_title();

};
=====Song.cpp=====
#include "song.hpp"

// add Song method definitions here:
void Song::add_title(std::string new_title) {

  title = new_title;

}

std::string Song::get_title() {

  return title;

}
