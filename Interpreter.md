# Interpreter

## Define
소스파일을 라인 단위로 해석하면서 바로 실행하는 프로그램.

## Goal
라인 단위에서 바로 실행한 프로그램.

## History
최초의 인터프리터 방식의 고급 언어는리스프이며 이는 1958년 스티브 러셀이 구현하였다.

## Difference with Compiler
- 전체 파일을 읽는 것이 아니라, 한번에 한 줄씩 변환한다.
- 매 행 실행하는 특성에서 비롯되어, 일반적으로 컴파일러보다 실행 시간이 느리다.
- 전체 소스코드에서 오류를 잡는 것이 아니라, 각 행마다 실행하는 도중 에러가 보고되면 이후 작성된 코드를 살펴보지 않는다.

## Execute Step
1. 소스코드에서 토큰 추출.
2. 추출된 코드 기호화.
3. 기호화된 구문을 분석하며 실행.

## Kind of Interpreter Language
### JavaScript
- JavaScript Engine을 통해 Javascript로 작성한 코드를 해석하고 실행하는 인터프리터이다.
### HTML
- HTML역시 컴파일러가 아닌 Interpreter를 통해 해석되어 파싱된다.
### Python & 자바
- 파이썬과 자바는 정확히 표현하자면 컴파일러와 인터프리터를 모두 사용하는 언어이다.
- 먼저 컴파일을 통해 Byte code를 만든 다음, 이를 인터프리터로 실행하는 것