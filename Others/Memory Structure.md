# Memory structure

## Define
The structure of the memory, produced by operating system, on which the process is.

## Basic knowledge
- There is a kernel area and user area in the main memory.
- When a process, executed program, fetch on the main memory, it will be seperated to following structure.

## Code segment
- Code segment is portion of an object file or the corresponding section of the program's virtual address space which contains **executable instructions.**
- When a program is stored in an object file, the code segment is a part of this file; when the loader places a program into memory to execute program, various portions of memory are allocated, which is corresponding to both the segments in the object files and segments only needed at run time.
> So, the code segment of an object file is loaded into a corresponding code segment in memory.
- Ususally, the code segment is read-only and has a fixed size, so on embedded systems it often be placed in ROM, without code loading.
- AS a memory region, the code segment may be placed below the heap or stack in order to **prevent heap and stack overflows from overwriting it**.

## Data
- Data segment is a protion of an object file or the corresponding virtual address space of a program which contains **initailized** static variables, which are global variables and static local variables.
    > If the variables are **zero-initialized**, or **uninitialized**, it will be in BSS segment, which is located higher than data segment.
- The size of this segment is determined by the size fo the values in the program's source code, and **doesn't change at run time**.
- Since the values of cariables can be altered at run time, the data segment is read-write.
- Data segment is located higher than code segment.

## Heap
- Heap area can be controlled, and must be controlled by user.
- The heap area commonly begins at the end of the bss and data segments and grows to larger addresses from there.
- Heap are is manged by dynamic allocation, which may use brk, and sbrk system calls to adjust heap size.
- Heap area is shared by all thread, share libraries, and dll in process.

## Stack
- Stack area contains the program stack which is a LIFO structure, usually located in the higher parts of user area.
- **Stack pointer** register points the top of the stack; it is adjusted each time a value is pushed onto the stack.
- The set of values pushed for one function call is termed a **stack frame** which consists at minimum of a return address.
- Automatic variables are allocated on the stack.
- The stack area adjoined the heap area and they grew towards each other; when they met each other, free memory was exhausted.
    > Stack grows toward address zero
    > Heap grows toward maximum address

## Conclusion