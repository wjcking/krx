using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct nod
{
    /**/

    public short
        nin, one, two,
        thr, fou, fiv,
        six, sev, eht,
        zeo;
    public static nod neo()

    {
        nod n;
        n.zeo = 0;
        n.one = 1; n.two = 2; n.thr = 3;
        n.fou = 4; n.fiv = 5; n.six = 6;
        n.sev = 7; n.eht = 8; n.nin = 9;
        return n;
    }
}

public struct ket
{
    public char
        nin, one, two, 
        thr, fou, fiv, 
        six, sev, eht, 
        zeo; 
    public char
        csa, csb, csc, csd,
        cse, csf, csg, csh,
        csi, csj, csk, csl,
        csm, csn, cso, csp,
        csq, csr, css, cst,
        csu, csv, csw, csx,
        csy, csz;

    public char
       cba, cbb, cbc, cbd,
       cbe, cbf, cbg, cbh,
       cbi, cbj, cbk, cbl,
       cbm, cbn, cbo, cbp,
       cbq, cbr, cbs, cbt,
       cbu, cbv, cbw, cbx,
       cby, cbz;

    ////separator sot
    //public char ace = ' ';//(space) 空格
    //public char kma = ',';//	逗号
    //public char dst = '.';//	句号
    //public char cr = ':';//	冒号
    //public char cr = ';';//	分号
    //public char cr = '/';//	斜杠
    //public char cr = '|';//	垂线

    ////separator sot
    //public char ace = ' ';//(space) 空格
    //public char cr = ',';//	逗号
    //public char cr = '.';//	句号
    //public char cr = ':';//	冒号
    //public char cr = ';';//	分号
    //public char cr = '/';//	斜杠
    //public char cr = '|';//	垂线
    ////Connector cot 
    //public char cr = '-';//	减号/破折号
    //public char cr = '~';// 波浪号
    ////Bracket bot  HandFirst.Left()Right
    //public char lsm = '(';
    //public char rsm = ')';
    //public char lmd = '[';
    //public char rmd = ']';
    //public char lbr = '{';
    //public char rbr = '}';
    //public char lkt = '<';//	小于
    //public char rkt = '>';//	大于
    //public char cr = '"';//	双引号
    //public char cr = '`';//	开单引号

    ////algorith why c++ may because  not with * / -

    //public char add = '+';//	加号

    ////special
    //public char cr = '!';//	叹号
    //public char cr = '#';//	井号
    //public char dor = '$';//	美元符
    //public char per = '%';//	百分号
    //public char and = '&';//	和号
    //public char cr = '\'';//	闭单引号


    //public char sdr = '*';//	星号

    //public char cr = '=';//	等号
    //public char cr = '?';//	问号
    //public char art = '@';//	电子邮件符号

    //public char cr = '\\';//	反斜杠
    //public char cr = '^';//	脱字符
    //public char cr = '_';// 下划线
}


//public char zeo = '0';//	字符0
//public char one = '1';//	字符1
//public char two = '2';//	字符2
//public char thr = '3';//	字符3
//public char fou = '4';//	字符4
//public char fiv = '5';//	字符5
//public char six = '6';//	字符6
//public char sev = '7';//	字符7
//public char eht = '8';//	字符8
//public char nin = '9';//	字符9

//public char csa = 'a';// 小写字母a
//public char csb = 'b';// 小写字母b
//public char csc = 'c';// 小写字母c
//public char csd = 'd';// 小写字母d
//public char cse = 'e';// 小写字母e
//public char csf = 'f';// 小写字母f
//public char csg = 'g';// 小写字母g
//public char csh = 'h';// 小写字母h
//public char csi = 'i';// 小写字母i
//public char csj = 'j';// 小写字母j
//public char csk = 'k';// 小写字母k
//public char csl = 'l';// 小写字母l
//public char csm = 'm';// 小写字母m
//public char csn = 'n';// 小写字母n
//public char cso = 'o';// 小写字母o
//public char csp = 'p';// 小写字母p
//public char csq = 'q';// 小写字母q
//public char csr = 'r';// 小写字母r
//public char css = 's';// 小写字母s
//public char cst = 't';// 小写字母t
//public char csu = 'u';// 小写字母u
//public char csv = 'v';// 小写字母v
//public char csw = 'w';// 小写字母w
//public char csx = 'x';// 小写字母x
//public char csy = 'y';// 小写字母y
//public char csz = 'z';// 小写字母z

//public char cba = 'A';// 大写字母A
//public char cbb = 'B';// 大写字母B
//public char cbc = 'C';// 大写字母C
//public char cbd = 'D';// 大写字母D
//public char cbe = 'E';// 大写字母E
//public char cbf = 'F';// 大写字母F
//public char cbg = 'G';// 大写字母G
//public char cbh = 'H';// 大写字母H
//public char cbi = 'I';// 大写字母I
//public char cbj = 'J';// 大写字母J
//public char cbk = 'K';// 大写字母K
//public char cbl = 'L';// 大写字母L
//public char cbm = 'M';// 大写字母M
//public char cbn = 'N';// 大写字母N
//public char cbo = 'O';// 大写字母O
//public char cbp = 'P';// 大写字母P
//public char cbq = 'Q';// 大写字母Q
//public char cbr = 'R';// 大写字母R
//public char cbs = 'S';// 大写字母S
//public char cbt = 'T';// 大写字母T
//public char cbu = 'U';// 大写字母U
//public char cbv = 'V';// 大写字母V
//public char cbw = 'W';// 大写字母W
//public char cbx = 'X';// 大写字母X
//public char cby = 'Y';// 大写字母Y
//public char cbz = 'Z';// 大写字母Z    
//                      //separator sot
//public char ace = ' ';//(space) 空格
//public char cr = ',';//	逗号
//public char cr = '.';//	句号
//public char cr = ':';//	冒号
//public char cr = ';';//	分号
//public char cr = '/';//	斜杠
//public char cr = '|';//	垂线
//                     //Connector cot 
//public char cr = '-';//	减号/破折号
//public char cr = '~';// 波浪号
//                     //Bracket bot  HandFirst.Left()Right
//public char lsm = '(';
//public char rsm = ')';
//public char lmd = '[';
//public char rmd = ']';
//public char lbr = '{';
//public char rbr = '}';
//public char lkt = '<';//	小于
//public char rkt = '>';//	大于
//public char cr = '"';//	双引号
//public char cr = '`';//	开单引号

////algorith why c++ may because  not with * / -

//public char add = '+';//	加号

////special
//public char cr = '!';//	叹号
//public char cr = '#';//	井号
//public char dor = '$';//	美元符
//public char per = '%';//	百分号
//public char and = '&';//	和号
//public char cr = '\'';//	闭单引号


//public char sdr = '*';//	星号

//public char eqt = '=';//	等号
//public char cr = '?';//	问号
//public char art = '@';//	电子邮件符号

//public char dsh = '\\';//	反斜杠
//public char cr = '^';//	脱字符
//public char cr = '_';// 下划线