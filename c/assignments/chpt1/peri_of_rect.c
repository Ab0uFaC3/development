/*
    Write a program to calculate perimeter of rectangle (take side length & breadth from user)
*/
#include<stdio.h>
int main () {
    float length, breadth;
    printf("Enter length of rectangle: ");
    scanf("%f", &length);

    printf("Enter breadth of rectangle: ");
    scanf("%f", &breadth);

    printf("Perimeter of rectangle = %.3f\n", 2 * (length + breadth));
    return 0;
}