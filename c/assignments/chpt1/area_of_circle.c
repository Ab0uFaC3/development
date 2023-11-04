/*
    Write a program to calculate area of circle (radius is given)
*/
#include<stdio.h>
int main () {
    float radius;
    printf("Enter radius of circle: ");
    scanf("%f", &radius);

    printf("Area of circle = %.3f\n", 3.14 * radius * radius);
    return 0;
}