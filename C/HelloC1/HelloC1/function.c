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
	// ����Լ� : �ڱ� �ڽ��� ȣ���ϴ� �Լ�
	// ���� : ���丮��
	// "n�� �Է¹ް�, n! ���� ���"
	// n! = n*(n-1)*...*2*1

	// n = 5, 5*4*3*2*1 ��
	

	// 1.n �Է�
	int n;
	scanf("%d", &n);

	int result = factorial(n);
	printf("%d", result);
}