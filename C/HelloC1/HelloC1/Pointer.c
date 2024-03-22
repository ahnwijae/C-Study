#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
int main() {
	// 포인터 : 가리키는 것
	// &(주소연산자), *(가리킨 결과값)

	int num = 5;
	printf("값 : %d \n", num);
	printf("%d\n\n\n", &num); // &주소연산자로 인해 num이 메모리에 저장된 주소를 출력
	
	// 포인터 변수 : "특정 메모리를 가리키는 변수"
	// num을 가리키는 변수 생성
	int* pnum; // 포인터 변수 생성, "어느 지점을 가리키는 pnum 변수"
	pnum = &num;
	printf("pnum 값 : %d \n", pnum);
	printf("*pnum 값 : %d \n\n\n", *pnum);


	// 예제 : 5개의 성적을 입력받고 성적값들에 대해 한번씩 순회하며
	// 60아래의 값이 발견되면 60으로 값을 변경한다.
	// 그 뒤로 5개의 성적에 대한 평균값을 구해라.
	// 다만 배열을 사용하되 포인터형태의 배열을 사용하고
	// int* pscore[5];
	// [] 기호는 포인터 배열을 선언할 때만 사용한다.
	// (배열값 조회에선 다른 방법을 찾아볼 것)
	
	
	int score0;
	int score1;
	int score2;
	int score3;
	int score4;
	int avg = 0;
	scanf("%d %d %d %d %d", &score0, &score1, &score2, &score3, &score4);
	int* score[] = { &score0, &score1, &score2, &score3, &score4 };
	for (int i = 0; i < 5; i++)
	{
		if (*score[i] < 60)
		{
			*score[i] = 60;
		}
		int a = *score[i];
		avg += a;
	}
	printf("평균 성적 : %d", avg / 5);

	
}