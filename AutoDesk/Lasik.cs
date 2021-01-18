using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDesk
{
    //public struct Lasic
    //{
    //    //Bin Oct Dec Hex abk dek
    //    //Bin
    //    //public const ushort Nod = 0;//十进制 Index Eidix
    //    //public const ushort Oct = 0;//八进制
    //    //public const byte Hex = 0;
    //    Hyper
    //}

    //显示器分辨率1920 1080，并且可伸缩性
    //镶起来 然后凯美瑞
    public struct Frank
    {
        //只能是边框  凯美瑞 上下左右边框游走 角钉 或游走滚动
        //public Cybert DockLeft;
        //public Cybert DockRight;
        //public Cybert DockTope;
        //public Cybert DockBottom;
        /// <summary>
        /// GetCharArray GetStringArray
        /// </summary>
        public Cyper[] LineArray;
        //Kaset as functions
        //Line;
        // Pine; 
        // Bine; 
        // Shan;

    }
    //public struct Kaset
    //{

    //    public Cyper[] Line; 
    //    public Kaset(int length)
    //    {
    //        Line = new Cyper[length]; //Rowlet(1-N)RowBack
    //        Pine = new Cyper[length];//ListDown(1-N)ListTub
    //        Bine = new Cyper[length];//RowBack(1-N)Rowlet
    //        Shan = new Cyper[length]; //ListKetub(1-N)ListDown
    //    }
    //}
    public struct Camey
    {

    }

    //public struct Lasik
    //{
    //    //       Bin Oct Dec Hex abk dek
    //    //Bin
    //    public const ushort Oct = 0;
    //    public const ushort Dec = 1;
    //    public const ushort Hex = 2;
    //    //public const ushort abr = 3;
    //    //public const ushort txd = 4;
    //}
    // int[,]  = new int[200];
    /*
   0	0	0x00            	NUL(null)   空字符
   1	1	0x01            	SOH(start of headline)  标题开始
   2	2	0x02            	STX(start of text) 正文开始
   3	3	0x03            	ETX(end of text)   正文结束
   4	4	0x04            	EOT(end of transmission)   传输结束
   5	5	0x05            	ENQ(enquiry)   请求
   6	6	0x06            	ACK(acknowledge)   收到通知
   7	7	0x07            	BEL(bell)  响铃
   10	8	0x08            	BS(backspace)  退格
   11	9	0x09            	HT(horizontal tab) 水平制表符
   12	10	0x0A            	LF(NL line feed, new line)	换行键
   13	11	0x0B            	VT(vertical tab)   垂直制表符
   14	12	0x0C            	FF(NP form feed, new page)	换页键
   15	13	0x0D            	CR(carriage return)    回车键
   16	14	0x0E            	SO(shift out)  不用切换
   17	15	0x0F            	SI(shift in)   启用切换
   20	16	0x10            	DLE(data link escape)  数据链路转义
   21	17	0x11            	DC1(device control 1)  设备控制1
   22	18	0x12            	DC2(device control 2)  设备控制2
   23	19	0x13            	DC3(device control 3)  设备控制3
   24	20	0x14            	DC4(device control 4)  设备控制4
   25	21	0x15            	NAK(negative acknowledge)  拒绝接收
   26	22	0x16            	SYN(synchronous idle)  同步空闲
   27	23	0x17            	ETB(end of trans.block)   结束传输块
   30	24	0x18            	CAN(cancel)    取消
   31	25	0x19            	EM(end of medium)  媒介结束
   32	26	0x1A            	SUB(substitute)    代替
   33	27	0x1B            	ESC(escape)    换码(溢出)
   34	28	0x1C            	FS(file separator) 文件分隔符
   35	29	0x1D            	GS(group separator)    分组符
   36	30	0x1E            	RS(record separator)   记录分隔符
   37	31	0x1F            	US(unit separator) 单元分隔符

   40	32	0x20	' ' (space) 空格
   41	33	0x21	!	叹号
   42	34	0x22	"	双引号
   43	35	0x23	#	井号
   44	36	0x24	$	美元符
   45	37	0x25	%	百分号
   46	38	0x26	&	和号
   47	39	0x27	'	闭单引号
   50	40	0x28	(开括号
   51	41	0x29	)	闭括号
   52	42	0x2A	*	星号
   53	43	0x2B	+	加号
   54	44	0x2C	,	逗号
   55	45	0x2D	-	减号/破折号
   56	46	0x2E	.	句号
   57	47	0x2F	/	斜杠
   60	48	0x30	0	字符0
   61	49	0x31	1	字符1
   62	50	0x32	2	字符2
   63	51	0x33	3	字符3
   64	52	0x34	4	字符4
   65	53	0x35	5	字符5
   66	54	0x36	6	字符6
   67	55	0x37	7	字符7
   70	56	0x38	8	字符8
   71	57	0x39	9	字符9
   72	58	0x3A	:	冒号
   73	59	0x3B	;	分号
   74	60	0x3C	<	小于
   75	61	0x3D	=	等号
   76	62	0x3E	>	大于
   77	63	0x3F	?	问号
   100	64	0x40	@	电子邮件符号
   101	65	0x41	A 大写字母A
   102	66	0x42	B 大写字母B
   103	67	0x43	C 大写字母C
   104	68	0x44	D 大写字母D
   105	69	0x45	E 大写字母E
   106	70	0x46	F 大写字母F
   107	71	0x47	G 大写字母G
   110	72	0x48	H 大写字母H
   111	73	0x49	I 大写字母I
   112	74	0x4A	J 大写字母J
   113	75	0x4B	K 大写字母K
   114	76	0x4C	L 大写字母L
   115	77	0x4D	M 大写字母M
   116	78	0x4E	N 大写字母N
   117	79	0x4F	O 大写字母O
   120	80	0x50	P 大写字母P
   121	81	0x51	Q 大写字母Q
   122	82	0x52	R 大写字母R
   123	83	0x53	S 大写字母S
   124	84	0x54	T 大写字母T
   125	85	0x55	U 大写字母U
   126	86	0x56	V 大写字母V
   127	87	0x57	W 大写字母W
   130	88	0x58	X 大写字母X
   131	89	0x59	Y 大写字母Y
   132	90	0x5A	Z 大写字母Z
   133	91	0x5B	[开方括号
   134	92	0x5C	\	反斜杠
   135	93	0x5D	] 闭方括号
   136	94	0x5E	^	脱字符
   137	95	0x5F	_ 下划线
   140	96	0x60	`	开单引号
   141	97	0x61	a 小写字母a
   142	98	0x62	b 小写字母b
   143	99	0x63	c 小写字母c
   144	100	0x64	d 小写字母d
   145	101	0x65	e 小写字母e
   146	102	0x66	f 小写字母f
   147	103	0x67	g 小写字母g
   150	104	0x68	h 小写字母h
   151	105	0x69	i 小写字母i
   152	106	0x6A	j 小写字母j
   153	107	0x6B	k 小写字母k
   154	108	0x6C	l 小写字母l
   155	109	0x6D	m 小写字母m
   156	110	0x6E	n 小写字母n
   157	111	0x6F	o 小写字母o
   160	112	0x70	p 小写字母p
   161	113	0x71	q 小写字母q
   162	114	0x72	r 小写字母r
   163	115	0x73	s 小写字母s
   164	116	0x74	t 小写字母t
   165	117	0x75	u 小写字母u
   166	118	0x76	v 小写字母v
   167	119	0x77	w 小写字母w
   170	120	0x78	x 小写字母x
   171	121	0x79	y 小写字母y
   172	122	0x7A	z 小写字母z
   173	123	0x7B	{	开花括号
   174	124	0x7C	|	垂线
   175	125	0x7D	}  闭花括号
   176	126	0x7E	~波浪号
   177	127	0x7F	  DEL(delete)    删除

   */

}
