/*
    Write a program to calculate average of 3 numbers
*/
#include<stdio.h>
int main () {
    
    float num1, num2, num3;
    printf("Enter num1: ");
    scanf("%f",&num1);

    printf("Enter num2: ");
    scanf("%f",&num2);

    printf("Enter num3: ");
    scanf("%f",&num3);

    printf("Average = %.3f\n", (num1 + num2 + num3) / 3);

    return 0;
}