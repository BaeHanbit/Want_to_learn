# Library (LIB,DLL)
## 2019-03-21

### Build <Compile + link>
1. 각 cpp 파일들이 obj 파일로 컴파일 된다.
2. 컴파일 된 obj 파일들을 linker에 넣어 실행 가능한 obj 파일을 만든다
    > 컴파일러가 생성하는 파일과 링커가 생성하는 파일의 차이는 생성한 목적 파일의 실행 가능 여부이다.

### LIB
- 정적 라이브러리로서 compile시에 필요하다.

### DLL
- 동적 라이브러리로서 Runtime중에 필요하다.