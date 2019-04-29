# PE file format

## Define
- PE format is a file format for executables, object code, DLLs, DON Dont diles, and others used in 32-bit and 64-bit versions of Windows operating system.
- The PE format is a data structure which encapsulates the information which is necessary for the Winodws OS loader to manage the wrapped executable code. 
> Portable Executable means itself, The file can be executed, moving from one to another. 
## History
- Microsoft migrated to the PE format with the intoduction of the Windows NT 3.1 operating system.
- All later versions of Winodws, including Windows 95/98/ME and the Win32s addition to Windows 3.1x support the file structure.

## Sort of PE format file
- Executable : EXE, SCR
- Driver : SYS, VXD
- Library : DLL, OCX, CPL, DRV
- Object : OBJ

## Technical details
- A PE file consists of a number of headers and sections which **tell the dynamic linker how to map the file into memory**.
- An excutable image is composed of various different section. So the start od each section must be aligned to a page boundary.
- Dynamic linker need to map each section into memory separately, and assign the correct permissions to the resulting regions, according to the instructions foud in the headers.
