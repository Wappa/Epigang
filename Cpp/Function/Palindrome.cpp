#include <iostream>

// Define is_palindrome() here:
bool is_palindrome(std::string text)
{
  int i = 0;
  int len = text.size() - 1;
  bool exact = true ;
  while(i != len && exact == true)
  {
    if (text[i] != text[len-i])
    {
      exact = false;
      i++;
    }
    else
    {
      i++;
    }
  }
  return exact;
}


int main() {

  std::cout << is_palindrome("madam") << "\n";
  std::cout << is_palindrome("ada") << "\n";
  std::cout << is_palindrome("lovelace") << "\n";

}
