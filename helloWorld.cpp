// HelloWorld.


/* # - that line is a directive that read and interpreted by preprocessor.
They're special lines interpreted before compilation of program.
This directive instructs preprocessor to include a section of standard
C++ code (known as header iostream), that allows to perform input and
output operations. */
#include <iostrem>
// This allows us to call std:cout without the std.
using namespace std;

/* Initates declaration of function named main. Execution of all C++ programs
begin with main no matter where function is located. */
int main() {

  /* std::cout identifies the standard character output device (screen)
  << indicates that what follows is inserted into std::cout. */
  cout << "Hello World!";
  cout << "I'm a C++ program";

}
