#include <memory>

// takes ownership of data
void consume(void* data)
{
	// do something
	free(data);
}

int main () {
   void* data = malloc(100);
   consume(data);
}

// How to solve this in C++?