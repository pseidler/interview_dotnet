#include <iostream>

class myClass
{
public:
    myClass() {}
    ~myClass() {}

    myClass(myClass &second) {i = second.i;}
    void increment() {i++; u++;}
    void print() {std::cout << i << " " << u << std::endl;}

protected:
    int i = 0;
    __int64 u = 20000;
};

int main()
{
    auto a = new myClass();
    a->increment();
    auto b = a;
    b->increment();
    a->print();
    b->print();
}
