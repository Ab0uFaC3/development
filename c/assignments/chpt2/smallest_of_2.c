/*
    Write a program to print smallest of number of two
*/
#include<stdio.h>
int main () {
    
    float num1, num2;
    printf("Enter num1: ");
    scanf("%f",&num1);

    printf("Enter num2: ");
    scanf("%f",&num2);

    if(num1 < num2) {
        printf("%.3f is smaller than %.3f\n", num1, num2);    
    } else if (num1 == num2) {
        printf("%.3f is equal to %.3f\n", num1, num2);
    } else {
        printf("%.3f is smaller than %.3f\n", num2, num1);        
    }

    return 0;
}