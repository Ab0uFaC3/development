/*
    Write a program to calculate area of square (side is given)
*/
#include<stdio.h>
int main () {
    float side;
    printf("Enter side of square: ");
    scanf("%f", &side);

    printf("Area of square = %.3f\n", side * side);
    return 0;
}