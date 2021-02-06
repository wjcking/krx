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

    public static implicit operator ket(Type t)
    {
        ket n = null;
        n.zeo = '0';
        n.one = '1'; n.two = '2'; n.thr = '3';
        n.fou = '4'; n.fiv = '5'; n.six = '6';
        n.sev = '7'; n.eht = '8'; n.nin = '9';
        return n;
    }
    ////separator sot
    //public char ace = ' ';//(space) 空格
    //public char kma = ',';//	逗号
    //public char dst = '.';//	句号
    //public char con = ':';//	冒号
    //public char com = ';';//	分号
    //public char dsh = '/';//	斜杠
    //public char spt = '|';//	垂线


    ////Connector cot 
    //public char cnt = '-';//	减号/破折号
    //public char cnr = '~';// 波浪号
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
