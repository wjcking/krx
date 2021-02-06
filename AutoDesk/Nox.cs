using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct nod
{
    public char
        one, two, thr,
        fou, fiv, six,
        sev, eht, nin,
        zeo;
}

public struct ket
{
    public char
        one, two, thr,
        fou, fiv, six,
        sev, eht, nin,
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
    //Connector cot 
    public char cnt, cnr, ace, cma, duo, con, com, dsh, spt;

    //Bracket bot  HandFirst.Left()Right
    public static implicit operator ket(Type t)
    {
        ket n = null;
        n.zeo = '0';
        n.one = '1'; n.two = '2'; n.thr = '3';
        n.fou = '4'; n.fiv = '5'; n.six = '6';
        n.sev = '7'; n.eht = '8'; n.nin = '9';

        n.csa = 'a'; n.csb = 'b'; n.csc = 'c'; n.csd = 'd';
        n.cse = 'e'; n.csf = 'f'; n.csg = 'g'; n.csh = 'h';
        n.csi = 'i'; n.csj = 'j'; n.csk = 'k'; n.csl = 'l';
        n.csm = 'm'; n.csn = 'n'; n.cso = 'o'; n.csp = 'p';
        n.csq = 'q'; n.csr = 'r'; n.css = 's'; n.cst = 't';
        n.csu = 'u'; n.csv = 'v'; n.csw = 'w'; n.csx = 'x';
        n.csy = 'y'; n.csz = 'z';

        n.cba = 'A'; n.cbb = 'B'; n.cbc = 'C'; n.cbd = 'D';
        n.cbe = 'E'; n.cbf = 'F'; n.cbg = 'G'; n.cbh = 'H';
        n.cbi = 'I'; n.cbj = 'J'; n.cbk = 'K'; n.cbl = 'L';
        n.cbm = 'M'; n.cbn = 'N'; n.cbo = 'O'; n.cbp = 'P';
        n.cbq = 'Q'; n.cbr = 'R'; n.cbs = 'S'; n.cbt = 'T';
        n.cbu = 'U'; n.cbv = 'V'; n.cbw = 'W'; n.cbx = 'X';
        n.cby = 'Y'; n.cbz = 'Z';
        //Connector cot 
        n.cnt = '-';
        n.cnr = '~';
        ////separator sot
        n.ace = ' ';
        n.cma = ',';
        n.duo = '.';
        n.con = ':';
        n.com = ';';
        n.dsh = '/';
        n.spt = '|';
        return n;
    }





    //Bracket bot  HandFirst.Left()Right

    //public char lsm = '(';
    //public char rsm = ')';
    //public char lmd = '[';
    //public char rmd = ']';
    //public char lbr = '{';
    //public char rbr = '}';
    //public char lkt = '<';//	小于
    //public char rkt = '>';//	大于
    //public char qod= '"';//	双引号
    //public char qos = '`';//	开单引号

    ////algorith why c++ may because  not with * / -

    //public char add = '+';//	加号

    ////special
    //public char alm = '!';//	叹号
    //public char csp = '#';//	井号
    //public char dor = '$';//	美元符
    //public char per = '%';//	百分号
    //public char and = '&';//	和号
    //public char sqt = '\'';//	闭单引号


    //public char sdr = '*';//	星号

    //public char eqt = '=';//	等号
    //public char qst = '?';//	问号
    //public char art = '@';//	电子邮件符号

    //public char dsa = '\\';//	反斜杠
    //public char art = '^';//	脱字符
    //public char udr = '_';// 下划线
}
