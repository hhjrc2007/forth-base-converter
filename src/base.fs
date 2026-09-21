: binary ( -- ) 2 base ! ;
: octal ( --) 8 base ! ;

: .bin ( n -- ) base @ swap binary . base ! ;
