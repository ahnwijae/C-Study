#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
// stdio.h = 입출력 함수 포함하는 라이브러리
int main()
{
    // 프로그램 실행 시 수행할 명령어 main에서 작성
    // 입출력 : printf()출력, scanf()입력

    int num;
    char ch; // C언어에는 String형 없다
    double d;
    // int > char > double 순으로 입력받기
    // %d > %c > %lf


    scanf("%d %c %lf", &num, &ch, &d);
    // $c : 공백을 입력받을 수 있다.
    printf("CCCC \n");
    printf("정수형 : %d \n", num);
    printf("문자형 : %c \n", ch);
    printf("실수형 : %.1f \n", d); // double형 출력시 %f 사용해도 무관
    // %.1f > 소수점 뒷자리 제거
    printf("안녕하세요 \n");

}