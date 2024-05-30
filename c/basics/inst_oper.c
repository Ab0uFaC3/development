#include<stdio.h>
int main () {
    
    //Type conversion
    printf("Int divide = %d\n", 3/2);
    printf("Float divide = %f\n", 3.0/2);

    // Operator precedence
    /*
        Priority     Operator
            1           !
            2        *, /, %
            3          +, -
            4        <, <=, >, >=
            5           ==, !=
            6           &&
            7           ||
            8           =

        Same precedence operator -> Left to right associativity
    */
   printf("%d\n", 5 * 3 + 6 / 3); // o/p => 17
   printf("%d\n", 2 * 10 / 4 / 5); // Left to right ass. o/p => 1

    return 0;
}