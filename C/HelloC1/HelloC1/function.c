#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
int factorial(int n) {
	if (n == 1) {
		return 1;
	}
	else {
		return n * factorial(n - 1);
	}
}
int main()
{
	// 재귀함수 : 자기 자신을 호출하는 함수
	// 예제 : 팩토리얼
	// "n을 입력받고, n! 값을 출력"
	// n! = n*(n-1)*...*2*1

	// n = 5, 5*4*3*2*1 순
	

	// 1.n 입력
	int n;
	scanf("%d", &n);

	int result = factorial(n);
	printf("%d", result);
}