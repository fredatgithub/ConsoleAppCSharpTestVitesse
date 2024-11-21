#include <iostream>

int main()
{
    std::cout << "test vitesse C++\n";
    double result = 0;

    for (int i = 0; i < 100000000; ++i) {
      result += i * 0.5;
    }

    std::cout << result << std::endl;
    return 0;
}
