#include<stdio.h>
int main () {
    
    // Variables
    /*
        Rules for variables -
        1. case sensitive
        2. 1st char can be alphabet or '_'
        3. no comma/blank space
        4. only special char allowed '_'
    */
    int number = 25;
    float pi = 3.14;
    char percent = '%';

    // Format specifiers - %d, %f, %c
    printf("Int = %d \n", number);
    printf("Float = %f \n", pi);
    printf("Char = %c \n", percent);

    // Input from user
    int age;
    printf("Enter age: ");
    // &age is address for variable age
    // Memory location where age variable is pointing, input data will be stored there
    scanf("%d", &age);
    printf("Age = %d\n", age);

    // Operators
    int num1, num2, sum = 0;
    
    printf("Enter first num: ");
    scanf("%d", &num1);

    printf("Enter second num: ");
    scanf("%d", &num2);

    // Addition operator (+), Assignment operator (=)
    sum = num1 + num2;
    printf("Summation = %d\n", sum);

    return 0;
}
