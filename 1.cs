#include <iostream>

int main() {
    double value, percentage;
    std::cout << "Введіть значення: ";
    std::cin >> value;
    std::cout << "Введіть відсоток: ";
    std::cin >> percentage;

    double result = (value * percentage) / 100;
    std::cout << percentage << "% від " << value << " дорівнює " << result << std::endl;

    return 0;
}
