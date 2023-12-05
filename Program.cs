using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Answer1());
            Console.WriteLine(Answer2Part1());
            Console.WriteLine(Answer2Part2());
            Console.WriteLine(Answer3Part1());
            Console.WriteLine(Answer3Part2());
            Console.WriteLine(Answer4Part1());
            Console.WriteLine(Answer4Part2());
            Console.ReadLine();
        }

        static string inputTask1 = @"fouronevhnrz44
eightg1
4ninejfpd1jmmnnzjdtk5sjfttvgtdqspvmnhfbm
78seven8
6pcrrqgbzcspbd
7sevenseven
1threeeight66
one1sevensskhdreight
rninethree6
eight45fourfgfive1
xdlnbfzxgfmhd4t
7tf
8oneldkrfcssbfeight
five5ninebvvfv
sixrhxkzcgfhltrchq3three91
lnxms8
threekv33eightninethree
fourxrsxhclj99twosevennine7htxdr
5hdhtdxgktztjdjrhkmlblsevenseven1four8
25xmvshkbmtkmvqpfhgq8fivefqctjm6two
nine533two
sixmbkjzpcxvfive2
seven3fivevhkpjvfqsfivemfdvlkhhmmvtztjf
3eight5threefour
fplrjjznseventwocrv9
mxqvdb5onesix84fpkzf
17five6mvxgkkmz2two2mf
lrqnqfncvvvrrpkfour92xsxfztwonehsb
dphngmgfhhhcjxmbmqdk3nine54
34xdbhnbhbmljxc55oneeight
cpgdcctwothreevlqmk1qpdthree
977ckpkmx5
7cx81
vrtgzhhrsevennzgjqhsqdxcjtm2gsj
dtkgj89bz5threenine
256mctgqnjbpr
smmthmrnj6threevrndhnrqq4qpnxz
vfrcvbgpdfjbzhchqmtjgxrmddhmggmqrgs7gxfjffivefour
twoeight8two3
threedpfour5eightthreebc3
csdfivefhgkjfcsvsvqsrbtplhjnine7pqhpvhjqone
seven3375sevenqgjndftrsh9
4six1npbnvfdl27hqvdrxztq
twopmmblrnhmq6zp1
34jvrtkfdcmnmblg269six5
fouroneeight1lpvssjskkjvhpmcb
kjb6
8rsix4
hcprhbhzgjklpql92pntdmxskg
3766zthm7lts
eight9sixqnkqbfrbrstbxxsixeight
sjncbhbcrmnmsmf4sixkhscclmrjfjgqgrdtpjqpgdsg3
zrxtgzscx5lgfcsbqkjnst1
nineonedzhsqlscgl2xpk
9eightljkpkkq
blhstnzdfttwocfjhgsix41hrx6
5dzsix5
vhlkone6five79
nkkm65tfnxhtmzrfpfive
7hcnzjn4
ngckn5ppcsvjsbstwo
5qld
zbgghnineninezkphpf6
8nine4sevenjlhlzlbztxbcrpc
3bcdmqxgb
8xvhfr3foureightwocj
nine68zvlfs
8one8xldlrninenine81seven
7dtvdvgnnqt6
htxkfzhxhfmc7631lklzppbtrbfive
seven89lrxddqtsvvt18
dnvcsqcmp7fourkrjhndsghjr
ztkqqqdctdeightonefivezdctxbfg7two8
lptlbtmmkdthreetfcttkknf53gtmvkcgmj9zvsvmsbstznmd
hbxr1ninefvjkkxkhbrtwo6
dbmxvpsvp7jdnvsdnlv
seventhree1
seven1oneseven
seventhreejcdvcgfthzlvl8eighttwo1
2fqkkgsvpjv9ninesix
xfmkdtxk2two
6fourfive
hpghf2cfgrmb34
714
nineonemrzxsmtwo28
llgnrpcdxt4eightninedl9
pdvhcvpmceightpfjpgvbfnrhh9
gvzzrvhmj464
592eightmvkdnjqthreedtcldng9
77nineonethreerqnrgczsn4hhdnpbtkxthree
four78zrqfourtwo
5chnktntwoninezqzfhthreegpmkvrsbfs
mpgvbnzldvbhchthreeseven4cvone
nmfbdpeightfour9fiveqnnmbfsheightsix
onexrjdhtmsdkssrgghlfsx5fourtwofive
5seven3zfdnqxqqdgqcphhjctjhddfggrfstqrb7
hcpcvfllseven8
qhpmcthree1sixdjkg
32mgqbmsn6five4c1
seven78
four8three
9seven5five6
five67
twopqsjvpfxdone81gsztrlxrhx5
9bctqg
jqkhxlnvfhninepzmvfmm5
fglgdrnlnqthreeeightfoursevenseven368
nineeightjvzdqnpnzf86qpffrfsp6
34kckxkrq
sixppr854
oneeight6
7onerhqgbzheightpvxjnsfdnmfive
68seven3
56ninedgzqmlvjp22
six69nine7threethree
6oneightskl
5six9four5twoone
fivefourfourhvgfqrqst99
2qvvnrbvjhs8dstfpfnineldkpnkskz7
41jrhj9nfeightonecqrdg
7onefour8
rxtdz5gbxbvdxbbpghfvljdbknqsqgtmmgrhf
79kftqmdnbj
1cf4
threekdrpvtsdtrdfzxtvqh3
zxcnsfkvfivezhcknlhcqfour9159
twodjdbsfive7two
47bnvbkseven4one7
nleightwo7
twofive5gptl3nine6twopngsq
eightqn32seveneightqfrfmsfgqhfourvrgdkfnxn
sixfivefivepnxb1jqzx4lk5
three97onebssix2
fivebvkhcmt3one6twonegf
xzrv997pfhxsblfive8
5nptkzbsixxgpmrkxponegnnqfqtgvl4
7mvxkfkjkxninesevenxjtrjxbj
jfloneightfivetwo7flmf
qpncksix1fourthreesixtwo7fcjjdx
17nineninesixhpbh
four88ngtbtfcqfr6tjqbqhrktf
vgtvfsftvljjkxnsevenltszqrgm6cgxjlqsgcqonelcdjv
6tznfmdzxkt
nineoneninefive2oneightdp
kmjjzvblthreethreefour1dhrsk2pfjx
fourfive6six2
rmqzgfivenineeightnine6qqnxclq
fourninefive3kgeightonerfxsr
four7qjpkrfxsvt31seventhree
vqgqgk69twoseven
qfxvmhk9
six1b69
vcbmbfjrdpnfour9
twoclpjtndvxj8fpxblseven
28xrggnqqttk544
39hgczgvjhvs31fivesix
qstz85sevennine
ddc5lqftnmhldv4dxfvhrxcnltr61
ninedhhmpzntqlninef7
63fourhznh
three39foureight
4zlfzjfrqsixjzb
2sfiveeight
fourfivefive46
fglfbbseven7445three5mfgrmkfgdc
8sg
128three3seven
five4threehrggrjgjpninetwo5eight
3hjnmvhtfxpzmdt7224txvnpnjsjf6
beightwobhz86fdhsthreeqjxccxhjvk45r
lgd2sixf7
6ninefour
hmhfeightsevenvlgdrm3five6kkjblfqbjsnxtcxrpg
jxvh5jjxvfdeightwon
1qfqdqxvtsztkkjxqz
1onenineppgphdtt
fourrppqprfmlpxbvdhpltfive1qfzr
xhqkzhchcmfnrpstgntwobrntnm4
nplmsixmx5six
dtvrlxzdb4clddlfivefour4one
67cnqshcbgsix54two8
7s
fourfourhbv28six91
seven6twospmcsixcvmzfj9nine1
1five1bphjprtm2twoxfslkqh9four
eight7bfzdbfccfl7
8eightl
klfpjslgdmgbxlftszdltn1
eightseven5threeseven
onenjvvqsfhgfhmtv6foureight51
qttmv8zxdh25hshpn4
7875
3ljptgbzsix1sgqrqlgml6sevenfktjtgtv
tdtwonethreeeightfivethreeqmdmc9
rkx1
eightseven26ftngc
tjxxsdsnxg696xhthree
2gdbxmxqjxnninefivenzhpmx3zqh
91kq5sixspxqqvpjxrp
mkztv5knjkzrgcz
3ninefpdbptdnine3qpzc
fourtwodg86
nineeight1sixfourseven
dvlgone1foursndcghxgxzrtsztceight8
6bskrcjthree
fourninebgcqkdlrx79
4sevenxfoneh
gmvptkcgx69vqxmckppmlnptsrndfrhtc
9959ngrjdgltllpmrtbrgrdpnjlgl6three
2c
3qncfdmhdcmleight1
3eightvfstts
sd7175nlpq9xhfour
foursevenfour477four
snsixthree7bmlrvdtmx
nhsninesevenjjhgthzhfour66seven
52onepcltqtlnk
fivedvndklt1twoxplzqtgf
1twohpd8xxtwojmcblxxtdk
nnctpnrhjtqvcpnbncpfsixseven9rrbxblhcsr
95ninemvhbqhpkqksixsevenone
5seventwothree
threeonetwonine2
cqbrtdnjzgx38twoneshm
4fivenine1
czsfivenkkqbqbbpc1
sjmeighttwo32one771
5mtmkhkhd7nineeightrq4six
one7vknzhj9ninesix
jcsqnxhp1pmfpvkdmcgzm
zjm5two2
4onejhdtnhqtlcggbxpmhtfiveone
nr6hvcspxjgvmlbdtgs326two
fivevsrfcv5fnkpftvrbnine
kbtwonesixbbrtjvcbblzh4
2fourthree
eightntgeightfivesix8
twoninefive42
bcjxfqlqvfslqgq52
tmrthree8twoxthreers
9fivenineeight9xdnnqkfbnkg
onesclfxsljp2
5one34
18nlbghthpmhntqpxnfivebfstnkcrpvxmrlrhcq
fourthreesix43three2fhn
nine5zbqpcxffpmmzxp
dbjgphmmvf7eight
6tks
ldnkcj6572two5sevenf
6jlbdqjrx86pxxnhneight
191pbjnlqh7vkgvrhtrkxqfgxczq
qpxpcnmmmone3zkm2nine5gttbdpggf
vnbfthmm1hckvdcqqv1sixxpldbmnxmmgrbl
eight5ftlsixlmrf
6gtqkvvmvvq5seven6mkxvxpfthreenine
jbskqm5gfntjjqtz
2eight72
nineplkthreesxpeightxzkfvg4
xzcqqnq5seven2vtsldzpfnine
six9t1rmbnzrkdh1
75kcdztv7
two4gbffour
seven8rlqhshzsixmtmpvfzjpeight5sixvh
7nrrcqpdqhfourthree
21fivenine2kjxmlmnhz6
3stsfthreejgzxhbseven7threebfhlml
dtdeightwo4jxrfivebpzf
qhrr2five5oneightr
pp2pbjgmgffctbtseven
737kbsxrtpcgslrmcnd4
qpxrkdnineqzkkhzjfqqv7twocghmkrh47
gfptsfour4ldrjlvzghq
9ninezvxqzhlgzckb8fztrsevenvlqgdm
7562sjpbvpeighttwo
qsmnktmlpznxz25gpgjqsm
7two5tctnfxgqvd2four
rls41threezlpkvtbhvk4sixnine
six8dpd
msljvkd6fourbtzfjphskfxqpjkzmzgkxvqn6hddzxj
mfspzjjcfour49csfjgjkdmktns
b3tllpmmqkktclkntlbgkkg9five
rqnbftghx35
rcgrb26five
sevenvkhzbljfour9czkpdltxlbqbdgcpz
two7fivehrqeight
mgmvtjl1zffzbt3two
trxmmtdrvh1scjhcsevenonejmzhsbttgfseven
one8sixtwo58
nrs24
threerrrrtjhngptrpsrq8sevensixtwoonecntmmmxtjf
mzgmrh5qcml
4lfxxdgnnjzeightninesone
phvmnnvzseveneighttwosixplbrb5
sixnineqqgbmlxdrvsrfhkrff5
6sdfldthgvctwosevenvvnbgqxjrn
7112xslv
sevenfoureightfivefivelkhnxb98
nine6pljkszdp6
two4xlhfhrz5kbpstsfive
bbgdsix5
sevenlcbsdlhftwozsnx1two5
one2jjmlqsnxx1b
sevensixsix5sevenzqhjzlkjgnvsxfkfvxzhq
lone19four1
1fivesixpv
eightfour1
xsbgprjfthreefoursevenrqzbcbfnbhtwo2two
ldtwoseven47dcrppbfbv
1fivexgtwosixone18three
nine93oneseven
5qdneight61xpg
rdzckkb5five7ggmbkzjshx
37lxlgmveight8
scqvdhm9b
seven9six
pvthreesixfourgctbsix8eightseven
83oneonej
5four83cfmnthreeone
fivefiveeight1
9tnbqpthbn5kvgmsmfmfsevenqdrksixmbmgm
onecrs76
vgdqvmt23onesix
dlvmvtj6eight2dxjrhdlfghfhxcsxz6tbkz
414sixdbzhmxthree
sevenfivesevencffvbdhtk5qmplrjzxnjnbnt6
qgqjxchmxfourknine447three
4tfour
fivercfvsvlfglbxrtvxznhr8five
sevensixonesix7399
two17
zcmdlqzhps5twotwojkltrxb7three
xllqtjpxsixsevenfivefour29
ninetpzpr51
6751three6
rcfpnskfivethreelbtgpltxsevenfourbtcs8eightwokb
eight7rfr2
six5onenine29
zjbj238
rgprs5fiveldvmgqktnn
meightwossfvkncf5sevenfivesqpgrtnnj
onez4eightfour62tmrjmprthree
foursevenjtwoc3threesixfj
qmmzmzlxmthreezvzxv6zgcztv
73mbm
nine251k1
sixhtfhzcbtq7sevenonesnkpfvsnnnine
seven44vp4jxbrvkzcmlnjfiveoneightvzx
3twoseven5
one8mfpgflgqkb2six7dtgftrplb
lrgnb4ninetwo5vjsmmb9
6sixq2three
999eightvkpcpv4
947fourtxdmhv
9msczjqjggsk3six4
bone1
5fivevvlljvmsdgqjnrhfourkstccckr
7hpblpnmxqlninethreesixpvpnine
nineeightdsrqfdnghgkeightone8mpkvfdhz
4sevencrjtpdq
mbvgsfoneltqkfnbpftxhtv7two
onegbvcctwo8onesevenone2six
vt36onetlmtqbv
nvvxx51
threefnvcvbnzvs4
7rxcjjdeight81587
mdmjsg3seventhreesn
dtxsdmsvjcjx819jhhpzzf9
9jcxsninetsl2
6vcllfssthkxgdgh1ghjscsrvnhrpmjllh
6kkhpcjhmseighteightppvdkffdcpchttzone
878
sixdkkjchkjqtllfpn31rpgxspktkgxjgcf
2eightsixzs3kx9
sixthreetwo9
35vtgrpcqcnvfive
4ninegqqlc49fourthree4two
czd4eight
tfcmfdxhhqlroneninethree43
8tbx
1xqpdxznzhsixseveneight2
6hg9clj
vfnthreevzt88
seven4317pkxd13
stvltfvs7eightcmj
nbrxfmsshronesevenrrnp8seven4
7jvtgqvm36fivegccbpkp
6threeeightfive8tnlninekb
eight1sixtp
17ninezjhchkvq
tfxvhhkltlnffournlmlsqfclqlrsk31
two889threezthree1two
five9one48twothree
eightseven8dqjsixlrsrscgzjpfour4
988nine4fk3
76dfkqfbqzffplx
9zmgrr9
jhsbj4twohxrgdr
kgcfgninetwoctqzfbhhvffive2fzlk
8six25
six35oneseven7
2cvxrnine33four27zk
4xctr9threemrckmkmjgtpxzfqdzg
fivelrs3ncmgdxgqhnfqrlzlnbvrqp
3zgblb
rztshfoursixfour226four
2hfth
5d94fiveninezfvprvgtnxfive
21four5zcb6szsjgsseight
2fivefpdkzxxgchfourp25lsnqjrmxmq
gxlbzlfzsixtwo8snhpdtgdgthkrvzsxkd3
five4n2
gscjzkgkeightqlljzx12fiveonebqzmlh
xhsrzj1
klxkdzxvvrljbnrhfive7four7
3sxmbgvxkmkpfqxccvj8eight2hl
2bcdbsllgcmftxftmzrhnfive9dgkqpqkloneskztwonesgh
eightsix7nine7eight69
five6lsgslhtzzv
fivesix47
3kxfbcjz6vmhzvkgpjbfqq34seven
threevlmlfm58threebkfdzd5fourkpgddjlqsz
sevenzdeightdtxrxzckfktrfpm7
qjkrfltlsdrrcm6
795six3hmlkdnine3
foursixxjnqsljktnnbtwoeight2mskdbkbtk4
fivetwothreeeight9sixqhqzm
fiveqjdksix14jlzcvck
16sevensixvzjnh
nkpshpkptggnsxp272three
zrv86
35lgqsdfive6
x3npthreethreercmnlphkchmrmcg9seven
5sixninefiveninenkxrvmk
jfjqrvc3
bbqxjhds4
hdkqkq5twodbbrpnbmmj
4twosixcfdcf515two7
mgzljdxqkpzbhfh62threenine74mcvrf
4ninesevenvnblskhgxmhvkhpmxg
fourvktpjlpr5sevencfvthree
9six9vtrkdfjkbb4five7slq1
dhroneight9xthreenjqk
eighttwo1twopxzxghjs9
six35ctcjrmfclone
d1sixmmctvr8
qsgcbzdtworzgzbqtrd7pttltxjsgptwomfmrzns
sevenseven6twocqhvmvgxn9vmlxpfourjvqsnmlbd
7twopc2four
three1nineeightgrnzbpqsvbkpbqzvmqsnm
91fdf985tdjvtwo9
svlfivetwomjhzfourone7
bqpssscxckkljxxtwo8dpcbpqgq
gjhdqvgcfive3five
bpqdnpbf97tgpkkmdg
1lksrsrlqkmzmbfgpcqq
kfftvhrlqpstwoone6fiverklbhqqgdpvmnine
xbtfhfivenine9lpklrnrrbnthreensvgrvdzpfpvzznq1
xkfjtzdqmhnine96sdgfveightttbhfkthree
fourbz2six5
rggoneighttwo19vfdjvjbr86zkqmfclp
3fourx4klhkhglvjszj8
glg2fournine5sixxbjseven
3zdpsone
htxgljmx262five5
3ftshpgpnnhgspltjrvb3cgnghgzpvzlnxvzcjone
threebbnrxczqninetrone7eightseven8
g2seven
threeddtgc8
3fivepcfgpvjzsj471
28zfour7seven
clxslzrrkbbmxbkzfnreightone6twodlztb8g
9eight1
2gvvdgnvnptwohhztfggrndzhplqgx
qspcbvlv48
1eight1sevenrlhdnhs
fivetpnnlnp317seven
n4onetwoninexnvstftnchzfxzrqts
2lthreeseven
two3twoseveneightffournbrhmseven
seven6fsxnfqmlg75bznfkjbch81eight
4dgszfourggjmjjjrr5xmddgsgp
b5283sbqdn36qcrxnphkg
9lmklvnvczeight
cgm2vsrmjtzmbh
7lhqhfm5sevenlg
69cmcnbqseven6bnztjrpfvx
eight84nine8
92xcmffvvbr
fivefivetwotwoglzqftlfpnine2
gtffdsrzmmnine6fourtwo
cjnxbkvxq7onexjjhds
onenine9lgkp4bxztcseven
bthree4
bqq4dbjbkftfx2cxdrdgjsixxqlcgztnv
twovtxqhsgx72jtgfqzfqnine4
87gjbghccqrsqxbflkhk2fivelmkmjzmfzxbcmjtb
seven7six83vdxxrfbfkfg
sevendnjssc7threecrccqlsf5xtgmqk
sjphck271threekvldbgnvtcxlcdkf
sevennpfbbsb3kgpdm
ngmhtfnkjl5fourfivegnpb
xthdbtwofcgdrrjmfive1five
89hgld6sevensevenfour6
36kgtmxxx1fivenineseven
eightdklr6
23zkrplrpmlpclqjkrsrxcbjone9ffjrqvsix
5njvthreeftxjninefnlcq
1qb
three5258kpcrl
szggtxbvql443
3threemvbzslgqdninesevenxzgbfkcg64
6fivefmhtdcbpx
five4fivesix
9ninebrdczqjpnine
q33ninesix6threepbqjnjdb
onelvhdtljltmjgdsnine1eight7
one2seventwo
4jnfchm5jtqgbmnctrsix
5six3
eight9hklfhjnine2onerl6
2nzncz9fourdcqmmcfgbgsqchvnrdnrcthree
2337
tvqqfkxcg81eightfivedxmb
mxkcbqkptqbgqvgjxbrbnine3dtzhkmeightsixdxdhbpxd
two9szthjhjmcfseven4
rkcsnrl2btjgvbmlnine1jdjczcskjg622
six75three9
5threethreetwo8
1eightngz
seven3sixn2
three7pdfjtzfv5threesxpgrbkmx2khxcsbdblh
onezzrzpbvsmflzrlfmv4h46five5
6jdv
smseven3eightfivegzlkm3
nine7eight5
sixthreeone54four
7mrxpdc6xvkhcmtwo4
3crrcmxzqzfchtnvnh
nhxtwoseven84
9sixvltbsix
6ctsnvvgm9sixpjhmtskzggtgsevenseven
ninehfqcvgkgqf167one1sixeightwocf
dtsg38sixtwonephq
rpfbnzn2vhjxeightqdfbqmpgpdqn
cncdqcbgzt8
xbhqsrfp6357ftq7
1rnnz277
8threeonejvkfldcrnxjflltr9
l8sevenseven8qmm5plczqnkrhvkppb
one7qjgnslmrdnbsone451xffltxrvdk
hmcmtzcl59
8qqffcfhj59
rzlkxvgckrfvnone2rjtwo
two9ninesevennine37
2x5
4cjkghzhtfrdhhcrjvt2
cpbhsgbzt8nzcjqnine5cntrngcqj
9three4sixeightcxmvmgglf
31dptlfdphx7three
fiveonethreesixppgpbzr8jlrpzhr
731bdfdvtpqb3pcbrsxvtxbtgphzdbsixfive
1gxmppthreetwo1xrslpjqq
2three3four4
pbdlpv56eight52
qmspclflmrckcbbqxnthreeone7dczkjhxnvjtkx
78dslfsggrkp
vntwonesixfourvsmmmgpghm3
three981flhdlvkseventwo
fqv9twopvk
pthpkvdqcn1
qtz763six8eightzxbcp
67vtscljxslhfpt8
2mqfhbpn
1jtdcgrlrpdmjbmlptgdzjfgqb
1twoeight6znzgxf8one
9gngqbsprhmhpsgzps
gjqsfhfivenine4pfhxthtjthgsm38
five1twofiveninetwofive2jrtzvtf
ninethreetbmcb2nine
96fztmrseveneightbhfpqjbsixvhjfvzzjdc
8threenineonejhhcmnnrzsnbzcstzqtfsthree
9onesixdttqqjvfour8
sixtcfdhjlddncmskrfoursix72
868fivevsstbpxtwo
four2onesix
four4ktnggkpfvtwozqqpsckb7
eightfour4threeninesixnbtzsevenjxpsn
sixfcmnbdflf7four7
mqvjfdhhbqkpkdx5sevenhrhkphqrsix
cb3bngnjgmjng
6jfive
roneightseven27fivetwofourfourbzshqvxdc
ltwone4zpvhninenm1eightktmkbpvlkkhzhvfc
84dslslds
bphdhtwo2ckktccnrqjptwo
six27glzs
threedxsdjsgmlvrtnmzjbvt71kdfiverpddfrczjhs
ddqlb4mtpfthreerkztrmxvbhhnjqmmdxdmlffcrhoneightfcg
qr1
56threenine6hgvtwotwofnjbppqppb
vb2fourninethree4knvzpjcj
threetlsevenfourgcjmzprone5three
5fourrrqhbrbq7three41
five8qpxdsdpxeightphjvbmtp
9one522
f3pklscq
4sjfiveht3xknmkndsgfjvl1zqdt
three4vjjg691
99grcttgddb
7pgh8sixsm5five
one185kjbftmplhqdkfvrh
4kzrchdkv2tgbrkghhnine6
sccnhhmmfournvbbvrlpfsevenfivefive8
frrrdkzvfg7blgqj7threecqhvvgfd
fivehsfkmbvxddkfrrngfivefive4four6
9onetwozcgntxrdzeight4zpnqkxsfpcggtrjjk4
5jbmn4nbzbmmkbvxstchl
fivenine4vvtfhrhbdeight4294
onefour749oneghm
one97czzjrrddjsb1nine
nine4sixsix
4eightthree3three
45rxpndjsmq6fourqpmk
seven93
5173five7kvgqpttwonemh
ninefive2n1eight
452zdvjfczspmcknblsmzznvrlhkmn
47onexntj2sixsixthree
nine9threesixfsmnfour51six
pgtfttdkjmz47
5threeone9gr2vjjcrbslcp
jsfour7fnmqgsxlnine2gsmmkgvj5gbvx
bktwonngqchlqghpnmlzxnthkpjgcjsr98eight
tczsjfcxfgjzbxeightnine5twoone
48
99flzfrrjdp69zxjdphrbbsixthreetpzn
five82fourxczgknkgk
six7fourbeight
oneeight4kxsdrpsix169dh
mnine9
npxvqkbpdtddhlggthreempqqblzfmmvc1mknf
56v9two24zdscdf
tmcbxhvhptvtwosdhltwo4mvjphvjjrsglrxbjrthree
threefive3skzsspkfqp61
three5three315xgjgphdr
8jvqvpspkqgbl
1vpkglvlxs2sixgc6eight3
hzshxqgxzttwovkfive3fgmctvvdfsbjhdt
prsqrjcrrj9nxgq2
dfsfxtdj19lqlblbmb1
ltlmvf81xsztgzpljcxx8
lrqxphqhthreetwolqjsixtwo81
nstpljlpt1sixnineone91
one4xcrhhdhsvveightfive
rfmdkpmbrhrnzqtqnrvdv4two5
ndf8mccqlzqrjjcpzzpbjrmclpkvkkltvgfsfour
two8three11eightwom
five5xpzcmtxnqj
7238fouronerxjvqtmhtljcnine
zdfmfkfbkb2seven
3fbkzxmz
21one699eightcqfs1
68vpgggr
97s9eight7
pkxvtvgtrdsqkgclnkxhjr3threelr
954lcthpqcscz
twothreevshxfjvnq6
rsnkplhfive3pmpkknnvbf6bvxqhbjhc
hhxhhpnrsevensztgxnqhmzcsnsxgblc7754
grjdsxzhjldjckhbxbrqlbbjhntjjv79
five7sevenfive
ghljgxzbfourcvqqnnine1rrmftfr
koneightbfxgjjzkkgsqzhhdctg4
cgtxldhfourtwoseven9zlhgrchhvfhrgmqdgnine
51twothree6x
sevenrfseven1sqmhzrg
bpnmzncsix3one6gzpzfsrfbp36
stjgqone46seven
gzrnkk7ninefour
fivefgnfkn4tzjxtjlrfive1
bdpgnthrf83nffzpeightmj
twotwovzbvbrsgseventhree15
7ninexqjggfvqndsdcg2
three8fivehpfxncpxv4three
twofive6rctmlhrxxlthreerrrvstvvqx
rgfdddkmvkfvjspmzzp6hxprqlvseven
threexhqqhone3six67l
eightseven56krtbthree
seven99
6j1czlmxsmqgzvrcjjscnineseven
ffnrkvchddftmhklsbxfourxmqnrnlrvvsevenone93
jlnzkqfvnsix8four74eightone
56eight1sqthzbsfpsevenhdlqkkqjqnqtbseven
dfsxgdsfnrktlhllrxqp5onevmfklvgxqhmlhgqhd8
cvtdzcsfive6rhggdz1tfzkffglck593
ninet715two1
gknjznhzvjrmqtkdbb5
xnrvvntwo22
9nlpcldct8nine5eightkjzmqskpnb
eightsix7ninetwopjslsgvbseven1
p2dcg49one
xcdthreessvvzts67bkqchqgqcf
31ncbk97
kxftjfivegmkcfqbvsl8threeqnrnrsixbdqzl
91fourpqfghjncnine8bfxqxdjckfckdzgsl
2vhrdjpcdlg
mrcjfivetwo6threenine
2ljldxrdg94four
gnoneghkgtt256
mxplnslnrsxpzlgx3nineonefive
63mzsvmsix
6fourninejpsfnineseven
fourninefive3threethreecmbseven
761zzctnddfour2one
dzonesixseven1two
fiver31oneeighteightwov
3kpbcxsthreeone5
nineonektx48drsgpktpns255
qfqtwone7nine374
xnsevenm9
seven8fourdptllvrggqzcnqfourtrbslxxgrrgj
onesix1sixngvmpbjctrkztfour1one
sjmxkkvddt89jlgfvhnlhlzzhdvp
jbk6
six4hkfbxrbg1ff7six
3six6fourthree6two
5sevensixonefour26
pgnzkprhj1rxsqftblftjgngthqdgmbdfmcpxxtsj8seven
17nine2kcnqv
ckzfgltmnqnkgzkxdfmncp8nine8
ccfourgfpdfrgmvdbvdvpd3
9bgqggggrbggmdrjkfivesvknmpthree
82sqghgstwoeightt
nk1slsckcn87cfsbggnsfnps67
1onethreefxdcqfourtpzqtwosix
pfivek4
99vnxnscjpeight4dthlk5eightwovl
rmtwonehkt6lczt8vfxmkzkxsb2five
one89bchlvvhtjz3zbspjtmkqkfourpznpfeight
foursqmchjpccone7ninenine2
1dvsgvone236six
six63three9
bvvgtrmmxs5scdzvcpseven7gdnxvczneight5oneightzbr
cv18cvdgxmrjsgnztgjrb4threefive9
ninesixsevennseventhree73
44dxhfgjt2gntv95
rbbhmmqbrc9twofour
4bqfivefiverdp658four
hpsslx88four
one8hmjrstmmeighttwodrmpm7five9
4ninen
9seven9fd442
3vqdtnhqg
hldgmmnfmzeighteightseven48
8msmbtzlvsf1ph4lkqddcbhcnp
jnkxqmghbpjslmgsbvlhtrr1njgrx2twozfk5
fxchjbvgl8mdhtckn8seven
rllvfrffhf13sevenc98
vgbprsjllsrhkltdrcknmfk1rpeightjpkxvjsrm
six81hgfzghnn8fivenseven
ninesrqjnt9onetwoeight63j
pbrrb9fqjhhfhfh9twokhhdsghvjkvkpj
1nineztppgztbdxvrgqvs46
jbqrdsqtfninefxtg1nzmdcqvg
41ninefiveninefiveone96
mmsfsjeightthreeqgbfbnvgnv5four4threepggz
6threehqq5four
mpthqgsix86two
5onesevenfive61
8ninetwoeightj31
7fivekxzhlxdsevenzn
sevenshxtsixzdfjvpcsc5jvjhgzbssbrqtwonemx
phls1
148nxbhkjr
2l8threeqfpddrjxrzlqldtqjseventwo
k7one
92sixtwotwoglmnxdnxz
9six4xdh
9five9nine
k21xc
sixonegsbffgtsevenzjbrone4chq
eightfive67fiveseven3four9
8lxzjjjshhgpvkmzcjjljr1fiveltt1
nine24eightts5xnfgtlpng5rkq
lhtwone1six8156zttxfdn5
69sevenmbkjdjbl
hnm8fivetwo
6threezc
lhmtbt7ltb6
six1eight4crjfmmxonenine
fhrvhfkp4xjstfour
kxeightwoseventlrvhfrkhrhfive34twos
sfvdlttlrfourthreevzksseven736
7crlzrzone8
fjsfpfivejxvqnq16threesixqxdmjz6
fkrjfjkgbjnine63fxfkfvphbjngnfqbhb2seventlbbr
596
dgfrd288six
783nine
two8fivefpkjllbnqgqlkqms7mmhbsrnhsxnbmjv
seven79one9
fourmrxqtmg21lnztkhx
3one728sixfive
fourconemgdcch8three
bfsfktfbvqfiveonecljcbqfnine2five
5eight2sevenzxpsk
6twotrvkhqrsppcxhjvjlkhcjrqpqvqxrmxqt
77kxkrpzr
grlrh36sevenone49
9fiveeight8
five4jbspqscf
4zzzjxghvcj
6xhrgnhxzx16xrknine
84nqhnxcdldthreeseventwodnbpszp
twoseven3xzpxpgjvbgldlqsgf
ncsfckp5cgv4jrbkf
9eightsixtcdkzlbl
sjfxx4
onebshtqkhslhfvhgqtvsnhqfhone4
fgggsixtwo4pl5
nvrr2twohknrgcxtpltwosgfbnlszeight
five1bzfdfsrz
4xvtwo2
five2eighth4
2jlnlmbqccrgkmjqninethreethreenine4
gtxxdnxqzlfive5seven
fivegjkqh46eight
33z
48sixscgcghlqjheight
vkfzkkxxnj17fivedt
onejlhdglpkjsixtwo24
4bssmdxpone1bnxjtwo
pbsixsfxddk3fivefive43eight
fivemnmqbzonetdgvmsone48
dbjeightwo9nine9
eight123kkptmzpqjj1
15krrcpgqshrhxrxpgone8kbkvgjlghc
45eight323hvnbtbqqtwoeight
veightwo2dsqjg
three77q6
1hshtr1vsbhfctfpdl1threem
nineninethreevvgbclnkcmzhctgjtwoseven4
seven3foursix4four
fhvm96bbxrmtcgcthree4rthree7
65crr
7ljvcqtceightbnkpbxqgfvfzxmfmctdjctgcc
llj659nine5rl
two8fivep3ddmpdhngm8cf
hljxhkvbk4five5k
threeninefive9
jncnpkxjvst2eightrjltjc
4psqtnkxrc
eightqtscplvmkbrlnine449nbnxtkz7
sixnvkbxlxninevhtdvf77zrnjzxfbdlsix1
eight2mznnrmhnmclxdcdzjsfourtxvgmdzvk
fkghbffpnmqblcrfivethreethree195
pxgpcrmpone1one
5pfkktxpfjgsixp5lbhrvv373
six8seven2fseven6
eight9crdxxxgpbprtdxpfsgglkst1
8zbmntvnpfoureightxz7four
3599lx5
seven9six4fdqr3vgq8
fiveone2twosevenfive
twotwo35sixczdx
two62964mdhbqhrfkf
phtrfmmkzonedcsnqdvrghvvf36thqdxfrh
dxnqsdhfivefour2385threeone
7onetwo
pfzrvpphj7phnzqmkbbbfvstwosevensix
69foursixonefive2
jszkfs9hkcsnxtzfs3
gqb1gzbglssfxqjvffivexlphdd7
2one777
qcczbcm4sevenseven
4threevxhtx
tdxxf8
jlxc5fivesixeight
sbszlkpjgfivevtsjscqdpv5eight56
bbpxxtwo798
fiveztdspgfive97zfmrvnxeighttwosix
51threetwovrbv5
fourfhxzgvbgdceightqnqrvmb7
11ngqhghdsevensthhs9
sevensevenrqmpsf4hnpqxmgbhskllksnkfourfour7
vheightwo5twothreehbzcrs
2fournpvcpksffj1
mxmldpfsevenpfcvhff9twonineeight
9pcqfrtkrtwo
hxxzppmlfive6cktznkfgmnctjfjpxvgdfszk7ptwo
vjjhjlqsvknineggvjdnnpltzrrqz7
9xdjlnqc
seven1lmdffjjqgxone
fiveseven9
5931zmck
twofourvzrdjmhbnl9onedrtcnl
4trmsevenhbsone
87pzvbcrdvzg3vfszszfds13
5three38gccjdm6six
xcszzrlpltbxs48mcs
ksjzvcgptnq3bfhrfx
twoninethreekhvndq8jfkrfpzsr71six
nine8zmnsdzxqhf4nine6nine
bsdvvggfrjvbvqrtjzbkzmcp64fourthree
nceighteightggrtjsblxdhpxsix7
ninebv8
136tjpsfdgnine
9q
seven1two
mtmzmplcnrfive3rtmhcxcxpsixeight2eight2
qclnh4
5d
tmvbmvh176jngdjlhszlfcbzv
two77jzfncqnm
onexdcrstcqlsixnmtxndzksfsvrxccmjj45
threeone58rzpfivenine
118zgl48
tfhdfive1gzz59bkztx
r3three4fourgzlgljdrmnmnjntssbpvkpmfdsjlbl
24hz
four8sixone6
nineqfggh3svpvlfzpfxoneeight6twohzb
941
onefivejnbgncqfzcsixdqd8rxjd2
9fivesixfivefivesix647
noneight25fhqrvv
eightninephmksl9dvhvcbvdldthree
threegr8
6fzqndfour5nine
4bl2zhcnpqvxthreemkjfqmdctsqzbkllfgvsmtt
9three13
hvbftpsbprhzx5
one7threer57
psdkpvjkzrs3sixfive
ngsqbpfbt34
gbdh7threexnszmtwo
64cmmt9sevenh8qdgmcpplgsj
fivervlsbzjsfiveqbmlrvlzqn8twoeight1vxzkjf
bznrgbrmnzvhp1twosix
97gldxj
fsjbjcklxp9nine2
hpgm7three
ljxcrlfive9bf
four894zmzmllzgkv
fivetmbkmmrjg9seven1tsix1
88sixgprtzhfzsncm4
dbdqkgtdxdjxhk3lsqvsmmtonexstlrplstvqvvmthree
sixfbvmqxbhbgfbl3
jkdshphdg1
sevenrkrvtwofivenine4fourcmjmmdvzvh
553
cqthreeone2ppfflh3fiveseven
5fivekxfzpzjsd42sevenzgfourtwo
55fivekrtckjphnlplbcbxbzf
1pgsfgdf755
5dncccmkpqtwocmmlltvbg
two23eight9lnjk
1148pdtcl1eight5oneights
4ltrvvtxfhcp8eight4dpfhmqeight
44xtvnlrcpb
9knzcfpkv2hqntgqkfgtsix1eight8
rlgmxxmpsk9
1one9
1six9fsvbrrgxqpsevensbnzshmb9
ftgbfqrzslqrcmmeightnjjrrkvhntcv1djmbqztrkvlqfkshoneightggd
one5twofqqgcdvzkllqgxhjpmkhsjpthree
sevenxtmq34two9gnvrvxfjmgq
nineeight6mkvbfour6four
6dcrpx8sixseven2bbszpncx3
6keighteightfive6six13
sixfive69sevenschkmdrvs
dzdgsmgcmkthxddd1921two7
fivenine9eighttworlrccrjzseven3
3onefoursix
6jzqksxpk
qfjhv1
sevennssgfpzt2bcxldkphfour1sixnine5
sx1zhzzpzonevrllpblsfnxzknmpconefktdt
mdvqxbgjhzprrhvqhdt6kfq
sclszppxlpzvzpscvqc791twochlgnsf4
krtjqmseven6tbllzgjcghsix1
114
75kp
rbrftcblxcknine4eight
ffmsgbqf33jcjktprgmczzkd6
v9zjhcvjjkr716
three49oneightf
ninesix2twobvdrbsvjrmvhsdhncsqhcfour
5thmkvcrfsix87hjhgbrxxfgseven
five8fourone24fqjknjq
xfmeight8
7onenine
fivesixfive2six9hn
7six441
1gjkphqtwo
fourhzgxqtxggfpprrmtfqsdhc2fdxnjdgx64five
threeninejdzzrbpmfhjcqdsix8two2bb
7877pzrbtcsddmrffzdsmqlqkjsix
5four3eight
15nine1";
        static string inputTask2 = @"Game 1: 14 green, 8 blue, 9 red; 5 blue, 4 green, 2 red; 4 red, 4 blue, 4 green; 1 blue, 3 green, 2 red; 10 red, 3 blue, 15 green; 2 red, 6 green, 3 blue
Game 2: 1 red, 12 green, 2 blue; 2 green, 1 blue, 1 red; 4 green, 2 blue; 10 green, 3 blue; 4 green, 2 red, 2 blue
Game 3: 16 red, 3 green; 7 green, 15 red, 3 blue; 4 green, 20 red, 1 blue; 12 red, 13 green, 1 blue; 2 green, 8 red, 1 blue; 16 red, 7 green
Game 4: 3 red, 7 blue; 4 blue, 3 green; 19 blue, 1 red, 3 green; 16 blue, 4 red, 5 green; 1 red, 19 blue, 3 green
Game 5: 7 blue, 4 red, 6 green; 2 red, 3 green, 6 blue; 11 blue, 1 red, 5 green
Game 6: 7 red, 13 blue; 2 green, 9 red, 7 blue; 7 green, 3 red, 12 blue; 11 green, 3 blue, 4 red; 12 green, 10 blue
Game 7: 2 green, 5 red; 4 green, 1 blue, 3 red; 1 blue, 1 green, 18 red; 4 green, 12 red, 1 blue
Game 8: 12 red, 9 green, 11 blue; 13 blue, 1 red, 16 green; 12 blue, 12 green; 3 green, 7 blue, 2 red
Game 9: 1 green, 9 red, 9 blue; 4 blue, 2 red; 17 red, 6 green, 3 blue; 3 green, 1 blue, 12 red
Game 10: 2 blue, 11 red, 3 green; 4 blue, 11 red, 13 green; 4 blue, 15 green, 4 red; 1 blue, 3 green, 17 red
Game 11: 9 green, 3 blue, 2 red; 11 blue, 16 green, 5 red; 7 blue, 3 red, 5 green; 7 red, 8 green, 10 blue
Game 12: 13 green, 2 red, 2 blue; 1 red, 6 green; 5 green, 3 red, 8 blue
Game 13: 2 blue, 5 green; 2 blue, 2 green; 2 blue, 2 red, 4 green
Game 14: 4 red, 2 green, 1 blue; 7 red, 1 green; 6 red, 18 green, 4 blue; 3 green, 1 blue
Game 15: 2 blue, 5 green, 12 red; 13 red, 8 green; 10 blue, 6 red, 8 green; 9 blue, 7 red; 2 green, 15 red; 9 blue, 3 green, 14 red
Game 16: 8 green, 11 blue, 14 red; 4 red, 8 green; 5 red, 4 blue, 3 green; 4 green, 13 blue, 6 red; 9 red, 8 blue, 11 green
Game 17: 8 red, 6 green; 5 blue, 7 green; 10 red, 6 blue; 9 blue, 10 green, 7 red; 1 red, 3 green, 5 blue
Game 18: 8 blue, 10 red; 6 red, 5 blue, 6 green; 16 green, 6 blue, 1 red; 16 red, 3 green, 5 blue
Game 19: 2 green, 17 blue; 2 blue, 4 green, 7 red; 6 red, 12 blue; 6 blue, 5 red, 10 green
Game 20: 4 green, 8 red, 9 blue; 6 blue, 4 green; 5 blue, 7 green, 9 red; 9 red, 9 blue, 6 green
Game 21: 1 green, 11 red, 2 blue; 6 red, 7 blue; 5 red, 1 green; 2 red, 7 blue
Game 22: 8 blue, 1 red, 4 green; 6 blue, 4 green, 14 red; 5 green, 8 red, 9 blue
Game 23: 4 blue, 12 red, 1 green; 1 green, 10 blue; 11 red, 2 blue; 1 blue, 1 green
Game 24: 5 blue, 1 green; 2 green, 2 blue, 4 red; 3 red, 5 blue
Game 25: 13 blue, 5 green, 4 red; 5 red, 17 blue; 6 blue, 8 green, 1 red; 2 blue, 1 red, 8 green; 3 red, 3 green
Game 26: 2 green, 9 red, 2 blue; 3 green, 19 red; 2 green, 16 red, 6 blue; 11 green, 4 red, 4 blue; 2 blue, 8 red, 13 green; 7 blue
Game 27: 1 red, 17 green, 1 blue; 4 red, 8 green; 1 blue, 7 green, 7 red; 18 green, 2 red
Game 28: 6 blue, 1 red; 2 blue, 1 red; 1 red, 1 green, 5 blue; 1 green; 1 green, 3 blue; 1 blue, 1 green
Game 29: 15 blue, 8 red, 1 green; 6 red, 2 green, 17 blue; 13 blue, 12 red; 12 blue, 2 green, 12 red; 5 red, 14 blue
Game 30: 4 blue, 6 green, 4 red; 3 blue, 2 green, 9 red; 5 green, 18 red; 9 blue, 16 red, 5 green
Game 31: 6 blue, 7 green, 4 red; 8 green, 6 blue, 10 red; 6 red, 2 green, 2 blue; 2 green, 4 blue, 6 red; 2 red, 7 green; 7 red, 13 green, 2 blue
Game 32: 5 blue; 2 green, 8 blue; 1 red, 6 blue, 2 green; 2 green, 11 blue
Game 33: 1 red, 7 green, 17 blue; 1 red, 14 blue, 2 green; 13 blue
Game 34: 12 red, 1 green, 1 blue; 11 red, 1 blue, 1 green; 16 red, 3 green; 9 red, 1 blue; 15 red, 2 blue; 1 green, 4 blue, 8 red
Game 35: 6 blue, 13 red, 1 green; 8 red, 9 blue, 6 green; 12 red, 8 green
Game 36: 5 blue, 3 red; 2 green, 3 red; 9 green, 6 red, 1 blue; 3 blue, 4 red, 9 green
Game 37: 14 blue, 3 red; 2 green, 2 red, 8 blue; 11 blue, 5 red
Game 38: 3 red, 18 green, 2 blue; 5 green, 5 red; 1 red, 12 green, 6 blue; 3 red, 5 blue, 1 green; 4 blue, 6 red, 17 green; 17 green, 6 blue, 3 red
Game 39: 5 green, 13 blue, 1 red; 6 green, 1 red, 12 blue; 1 red, 2 green, 11 blue; 1 red, 2 green, 12 blue
Game 40: 15 red; 14 red, 2 green, 4 blue; 13 red, 5 blue; 5 blue, 1 green, 18 red
Game 41: 2 red, 15 green; 11 red, 6 green, 17 blue; 10 green, 15 red, 9 blue; 8 red, 4 blue; 1 green, 13 blue, 13 red
Game 42: 3 green, 3 blue, 1 red; 2 red, 8 blue, 1 green; 7 blue, 2 red, 1 green
Game 43: 8 green, 10 red, 4 blue; 3 red, 11 green, 10 blue; 4 red, 5 blue, 2 green; 9 green, 10 red, 4 blue
Game 44: 3 green, 4 blue, 4 red; 10 red, 5 green, 4 blue; 1 green, 16 red; 2 blue, 15 red, 6 green; 13 red, 2 blue, 4 green
Game 45: 5 blue, 3 red; 1 red, 3 blue, 17 green; 2 red, 3 blue
Game 46: 9 blue, 10 green, 5 red; 1 red, 5 blue, 1 green; 6 blue, 8 green, 9 red; 2 red, 4 blue, 11 green
Game 47: 3 green, 7 red, 7 blue; 12 red, 1 blue; 6 blue, 4 green, 6 red; 6 red, 5 blue, 1 green
Game 48: 5 green, 1 blue; 2 green, 8 red, 4 blue; 16 red, 12 blue, 8 green
Game 49: 19 green, 4 blue, 9 red; 3 green, 1 blue, 8 red; 7 red, 1 blue, 14 green; 2 blue, 7 green, 2 red
Game 50: 6 blue, 11 red; 1 green, 8 blue, 11 red; 5 blue, 1 green; 4 blue, 12 red, 1 green; 1 green, 6 red, 8 blue; 7 blue, 5 red
Game 51: 5 red, 7 green; 8 green; 4 blue, 7 green, 2 red
Game 52: 3 blue, 12 red, 1 green; 13 red, 1 blue; 7 blue, 8 red; 7 blue, 9 red; 4 red, 5 green
Game 53: 2 blue; 1 green, 4 red, 12 blue; 1 green, 7 blue, 4 red; 8 blue, 1 green, 4 red
Game 54: 2 blue, 7 green; 1 red, 1 green, 2 blue; 5 red, 5 blue, 7 green; 5 red, 5 blue, 6 green; 7 green; 7 green, 2 blue, 5 red
Game 55: 2 green, 20 blue, 3 red; 2 red, 1 green, 1 blue; 2 green, 14 blue, 2 red; 2 red, 11 blue; 8 green, 4 blue, 2 red
Game 56: 5 red, 1 green, 10 blue; 2 red, 1 blue; 1 blue, 2 red; 1 green, 8 blue
Game 57: 1 green, 4 red, 5 blue; 20 blue, 4 red, 2 green; 17 blue, 1 green; 1 green, 10 blue, 1 red; 3 red, 17 blue
Game 58: 15 green, 2 blue; 15 green, 4 blue, 2 red; 14 blue, 5 red, 15 green; 15 green
Game 59: 1 blue; 5 green, 8 red, 1 blue; 15 red, 2 blue, 1 green
Game 60: 3 green, 4 blue, 16 red; 6 blue, 10 green, 10 red; 2 blue, 13 red, 8 green
Game 61: 2 green, 2 blue, 3 red; 7 blue, 15 red, 9 green; 5 green, 1 blue, 8 red; 4 blue, 6 green, 18 red
Game 62: 5 red, 7 blue, 13 green; 7 green, 6 blue, 8 red; 6 blue, 8 red, 12 green; 2 blue, 6 red; 5 red, 4 blue, 5 green
Game 63: 3 red; 5 blue, 2 red; 10 red, 1 green, 4 blue; 5 blue, 4 red, 3 green
Game 64: 7 blue, 3 green; 5 red, 6 green, 14 blue; 1 green, 12 blue, 9 red; 1 blue, 8 red, 12 green
Game 65: 12 red, 12 blue; 5 green, 12 blue, 11 red; 6 green, 3 red, 14 blue; 11 green, 4 red, 1 blue; 11 red, 3 green, 2 blue; 13 blue, 9 red, 5 green
Game 66: 1 red, 1 green; 3 blue, 6 red, 3 green; 6 blue, 1 green, 4 red; 8 green, 1 red
Game 67: 2 green, 8 blue; 5 red, 7 blue, 4 green; 8 red, 5 green, 5 blue; 2 red, 1 blue
Game 68: 3 green, 14 blue, 3 red; 16 blue, 7 green, 4 red; 10 blue, 6 red; 4 green, 3 blue, 5 red; 2 red, 14 blue, 8 green
Game 69: 11 red, 1 green; 1 green, 4 blue, 13 red; 18 red, 3 blue; 7 red, 1 green, 9 blue; 5 blue, 1 red, 1 green; 3 red, 4 blue
Game 70: 10 blue, 2 green, 4 red; 4 green, 4 red, 2 blue; 7 green, 5 red, 1 blue; 7 green, 3 red, 10 blue; 7 green, 2 blue, 5 red; 1 blue, 9 red, 2 green
Game 71: 1 green, 6 blue; 10 blue, 2 red, 1 green; 8 blue, 1 red; 11 blue, 2 green, 3 red; 1 green, 10 blue
Game 72: 10 blue, 3 red, 2 green; 11 red, 4 green, 3 blue; 1 blue, 4 red, 3 green
Game 73: 8 red, 17 green, 3 blue; 5 blue, 10 red, 8 green; 9 green, 12 red, 3 blue
Game 74: 5 green, 4 blue, 1 red; 4 red, 6 blue; 2 red; 2 blue, 1 red; 3 blue, 1 green, 3 red
Game 75: 4 blue; 3 red, 10 blue, 14 green; 8 blue, 3 red, 11 green
Game 76: 10 blue, 15 green, 5 red; 14 green; 6 blue, 10 red, 13 green; 2 green, 10 red, 6 blue; 1 red, 6 blue
Game 77: 3 green, 5 red, 8 blue; 14 red, 15 green; 14 green, 1 blue, 2 red
Game 78: 5 blue, 5 green; 9 blue, 2 green, 5 red; 4 red, 4 blue, 1 green; 3 red, 10 green, 2 blue; 4 red, 12 blue, 3 green; 4 green, 5 red, 13 blue
Game 79: 6 red, 1 green, 18 blue; 5 red, 11 blue, 2 green; 2 green, 4 red, 4 blue; 7 red, 17 blue; 9 red, 1 green, 3 blue
Game 80: 5 blue, 6 green, 6 red; 2 blue, 8 green, 8 red; 5 green, 16 blue, 3 red; 2 green, 3 red, 1 blue
Game 81: 11 green, 5 blue; 1 blue, 10 green, 1 red; 3 red, 3 blue, 15 green
Game 82: 14 red, 11 green; 2 green, 11 blue; 9 blue, 7 green, 7 red; 13 blue, 17 red, 3 green; 12 green, 15 blue, 8 red
Game 83: 2 green, 9 red, 4 blue; 3 green, 4 blue, 5 red; 2 green, 9 red, 7 blue; 4 blue, 3 green
Game 84: 4 red, 3 green, 6 blue; 2 blue, 5 red, 2 green; 6 blue, 1 red, 10 green; 1 green, 1 blue, 3 red; 16 blue, 6 red, 2 green
Game 85: 14 red, 4 green, 6 blue; 11 red, 2 green, 6 blue; 9 red; 3 blue, 13 red, 8 green; 3 green, 2 blue, 8 red
Game 86: 4 red, 1 green; 14 blue, 3 red, 2 green; 5 red, 3 green, 5 blue; 13 blue, 11 green, 1 red; 1 green, 14 blue, 3 red
Game 87: 1 blue, 2 green, 4 red; 11 blue, 3 green, 4 red; 11 blue; 4 green, 11 blue, 3 red; 4 blue, 5 green, 2 red
Game 88: 1 red, 1 blue, 1 green; 3 green, 1 blue, 1 red; 9 blue, 5 red, 5 green; 3 blue, 5 red, 8 green; 2 blue, 3 red, 13 green; 8 blue, 3 red, 9 green
Game 89: 3 green, 12 red, 11 blue; 10 red, 7 green, 14 blue; 17 green, 9 blue; 15 green, 1 red, 3 blue
Game 90: 12 green, 7 red, 5 blue; 12 green, 1 blue, 6 red; 6 red, 3 green
Game 91: 11 red, 10 green, 15 blue; 5 red, 6 green, 2 blue; 3 blue, 9 red, 7 green; 11 red, 1 green, 15 blue; 10 blue, 4 green; 9 red, 7 green, 14 blue
Game 92: 1 green, 6 red, 4 blue; 5 blue, 1 green; 6 red, 6 blue
Game 93: 19 red, 8 green, 9 blue; 7 blue, 1 red, 9 green; 2 red, 9 blue, 11 green; 1 blue, 4 green, 10 red; 10 blue, 11 red; 4 green, 8 blue, 16 red
Game 94: 11 red, 1 green, 1 blue; 4 green, 8 red; 2 red, 1 green; 4 green, 5 red; 5 red, 1 blue; 1 blue, 2 green, 9 red
Game 95: 6 green, 7 blue, 8 red; 1 red, 7 green; 16 green, 2 blue, 3 red; 5 green, 10 blue, 8 red; 5 red, 16 green, 3 blue; 4 red, 10 blue, 12 green
Game 96: 6 blue, 5 green, 6 red; 3 red, 5 blue, 4 green; 2 blue, 2 red, 3 green
Game 97: 3 red, 8 green; 2 blue, 3 green; 13 red, 10 green, 3 blue
Game 98: 4 green, 9 red, 2 blue; 1 blue, 5 green, 18 red; 3 green, 16 red; 15 red, 1 green, 2 blue
Game 99: 7 green, 2 red, 5 blue; 9 red, 17 green, 19 blue; 8 red, 12 blue, 1 green; 11 red, 11 green, 10 blue; 19 green, 4 blue, 2 red
Game 100: 4 blue, 3 green; 5 blue, 12 green; 16 green, 1 red, 1 blue; 2 blue, 1 green; 1 red, 3 blue, 18 green; 3 green, 1 red, 3 blue";
        static string inputTask3 = @"...317..........214.....................................751.................................630...479..205....41.993............416.........
...*....813........%....572........%...629.154......518....*....365..................-.......*.......#.....................422...........661
269.......*...58...........=......264.....*..........*......937.-...........235...303.........848..............195.....154*.........144.-...
........476..@...162.855................$....288...821..............107.....-...........290......../..301.........=...........135..*........
618.............=....*...547...........441....*........................@................*........851....+...................+..*...102.310..
...*961....905......534..$...377...............854...341.342....485.......109....89.995..927..............................90..997......*....
............*...................*.................../.....*......@...........%....*...*.......................+44.....913.........9.....891.
....62......724...592....946.878...854....$.701............480......575.246....119.....54..296.906..684..................*.........*838.....
.................+......*...............478....................469.....*..................*...........+..502..156.........821...........983.
....................315.764..996..571...............=........................804.......&...892....958.....*......*.............61...........
........+...697*.....+.........*...*...........@.448........................*.......322.............*....309..37.602.....775....*...........
32.480..665.....557......+...435..449..691..327....................#....921..535..........755...43...597........................322..7......
......*.....848.........745.............*.......679/............106.......&........404......+....*...................888..750........*......
......93...*....=.............*297......550...........324.597............................................819.....997*......-...734$..588....
.........363..112..754...............&..........723....................14..954.............175....773...*.............&.....................
..................*.......#..........502......../...............606.........@..778*.......#.........*....844...713...743....-.........&.....
............827.895.-539...469...938...../.248.....................*.49............749.............783.........$...+.........33....471......
..............*.................../...517...&......368*710......432...*............................................841.=.................194
.....*491....395.......&481.................../.#...................83................668..181.....698..155*...........981.200..............
...................219.................196.473..224.....=.....733*.......=.........98*.......*.420..........671.....*......*......369.205...
........@......696*....669.....50.....................853.593.........168....@.............802..*...388............3......792........*......
......641............./....62..*...836#.......*169.........@...............872.................416....*.................-...................
..........................#...377..........179.......101........+504.................*554.............947..............447.............830..
243........*902.....#................480*...........+.....*258.........*243.......389.......&....................723.........838...991......
........182.........33..........840......616.733.......756..........290.....................145..119..........................+......&......
..............................................*....807...................777......+..556............@....85#................................
.212.664..3......316..579..462..............435.......*............@....*........36...$........572................703..732........@.........
...........=....@.....*.....*............*.......-..337......656...411.357.373.....................*21....37.........%./.....918...185.387..
...350.................338...161.856..157.906...527...........*............+.........*336.......204............755.............*............
....&...........683...................................801......313............831.230......374.......................383.....940.48.........
...............*........447......635....335......%.........627........44@..........................895....................@.................
....$....958..943.......#...935.%..........*...794......16.*..................+...........100..469........743.*.........529....=.......883..
..308.....*........*776.......*.....*....430............*..562.......895......765.................*.........*..776..........246..921&.......
.........200...............*..1....572................814...........$......#..........138...&....487..668..58.......485.....................
...*845.............935...958.................................667.....%.121.......691.......245.........*..............*........131.........
.........*............*.............=............................*.593.............*..................380........189...219.211......@.......
.....152..783........634...........521.+.......26.............659...............328...%.............................*........$......397.*...
......*.......124..........299..........808.....*........359................424.....%..454..........553.............49..562.....257......723
......641.........24.............576.............975........=..............*.......974.............*...........146......*......../...@......
940.........&....@....221........*.........149.......&...............689....418...........538...................*.....985............526....
.............192.........*816...582...561..+..........915..981%.......*..................*......&8....+.........497..........145............
.........144........$....................@......................425.933....846*824.$...370.342*....375...641..=........927.....*.......160..
............$.......925...67.655....57.............=905..881....@..................585.........746.............224..........224...864...*...
.....872................#..*...$.....*.........#............*...........979....699...................947.........................*.....788..
............949......676..42........340.....694...144......712..296..45...*.......*..............191.@.......889-......=786.....417.........
...........*.................846....................*..160.......*.......403.....347...914.91...=...........................................
.371.=....904.643......816...*...647...$.858.......431..........486..........706......*....-..............961........................698....
......398.....*....252*....591..../..224...$..341...........#................*................956............*...27..............57.....*534
.............363...............................&.............69........163.233.580....113*367..............44...*..................*406.....
...893..457..........91%........................................538.....$......*..............................475....864.......289..........
..........-........................549............909..572.....-..............385.............97.....................=.....159..*...........
...174...............................*...576.875....*.....=...................................*....506..115...............*....856....408...
.....=.......685....58........177.965...-.....*....489......402/..&603.....................357......=..&....84.....451&.810........93...*...
.....................*...87.........................................................447........@............*................-......*...117.
......205.593........298..................................622....955.......34*325......*....965...................604......729....509.......
........=..*.......+...............966.......................$.$...................206......................99....-....424..............$...
378..........636..141.543%....34...........437-.................303.........80....*.............915...........*........*...885...........148
............*................=......................39......-.......208.560*...906...................320.860.975....532....*.........740....
....834...13...................426.395*962...44.......-......552...................*539.+........953.......%............647.........*.......
..............589...............*..........................................179...71.....207........#.577......758...247..........958........
....930.......*......&139...820.56.....%164....................536.=31......*.............................................89................
.....#.........569............*.............882....296......&................465.......21............=.....331........998*..................
..........847..............206....$............%.....#.464.318..=.....751*........................501..971...*..............227.......854...
.466......*......768..../.......110......................*.......612......551......868.......727.......*......39.850..-.....*.........*.....
.........377.561....&.718...94............246..........159...........255............%.........*...........445........472...520.......304.472
...............*..........................@.....292.............................476......&.........135......*...223.........................
..............288.....................944........*......775*934................+......152.............*55..806............239#..............
...181*552...............................*....238...............499...880.476...................................417.#66.........472.........
.....................*........%...629.853............*......@9...@......=.....443...673........271...*..........-...........98..............
.........567*288...10.257..837......*.........862..14................21......*...................%..714...........963.........%.450....528..
....................................862..................889.....604...*424..350...812..34........................*...646...................
...............*....*933.....355@..................*528....=......................+.....*...&996..493.....992..840.......*..271.............
..............984...............................678.................+571.....648......262............*......*..............*......293..197..
..........386..............463..984......129................-588..............*..361...............408..269.652...........406........*..+...
.........*............494....*.......847...*..#..942..825.............&......32.........................*........427...........-....339.....
.......415.=434..439.....*..23........$..34..410.........+.......746.976.............731..../.1*.........709.......*.........197........#...
................*......493.......760.............................................654*....398.........158....../......396.............922....
.....845.=....955...................*.....*574....954*........@...........$.......................-....*.....796......-...426...$732........
.......*.88.............@.........738..924............213...40....115......315...................299...108...................*.......320....
....567...............%..13.................*14...........$.......@.....%.........../...518.......................-.810...514..952..........
........892...275....485.......820.......367.......@.....544...........428.........54..-.............*....108..964...*..........*...........
.......@...................861......#.........893.116.........836.982......961.............../...615.188.....*.....914.........761....765...
...........169.962.........*......81...769...#...............................-..714.424..759.390...@.........855...........562.........*....
....../906......../......81..968.......-..............................185..............*.%............=......................*.205.....72...
................*............*....110........./.907....241.......708...*...383.701..869...............346..............649.771.#............
.............531.976...670...288...........382....*.......*116.........820.-...*............764..556...........@..984....$.......638...165..
........................-..........479.............55..........................515.....345...#................533...*.......................
.....$....569.936.301.........914..*.......-.....=................453..............209..*..........................551.-.......479..........
..233.....*......*.....506.........931..246....221.639....#..................@......*....784........591.................818...%.......523...
.......233....%.........................................416...714&........448.......698......387........432............................*....
...........718.......@......465....................430........................603.......491..*..........*...22.164...+...............179....
...............450.462.549.=....283.185...880......................652.......................142..430.372.....*.......633...................
.370....143....*.........*.........*......*.....962...........*.....*....................537........%...........&136........................
.....39.......956......213...........476.143.......*.......321.60....708..........966.......#...921......+146............+...665............
...........................941...321*.............880.499...........................*.............*.383........668.....212...*....827*428...
..236..527...................=..........................*........../..854......................489...-........................234...........
.....*.................................622..........289..599....207...*............&953.599=...............885............682.....914.....12
793...754.............$497..............*............*................163....................+.........15.....*..*....338*..................
...*.......864................348..........758.......439...................1........83....748...............325.535...................=.....
...368....*........382*250....*.....317.......*................473*....877.+.........*..................@................%....331..513......
.........55..239...........2...377...=......1.792...294*607........831..........*.950...&....-....#....864.....139.......512................
....427.......*...*...#....%...........765...............................418.995.........6..492.465...........@....................*218.....
......*......939.410.371......#...-......#.................&............*.............................496..........503..........629.........
.....410....................215.193.................678.786.....370...71..598......329..........262.................*.......473.............
.........979..855..432=................212.....346..*....................*........*............#...................249...=.....+...525.217..
.........*....*...............387.....*...........*.228......./....%....245..&.....690.....429............................685.........*.....
129....907.423........949.772......666....173..679........992.313...398......427..............*...................244.......................
.........................*.....*............................*........................../....998..........510..825*..........................
.....132....867........%.....42.780..............776*744...898.......664....196....360..823......899.211..=.................+...............
.....*.......%......703................916...%...............................*....*................*....&.....689..$......591.......64*238..
...684..160.......................445.....*...164.......602....249...........431.12.............=..758............138..........983..........
..........@..766.92..............*......334........671..*...............&646..................797.............950.........935.........469...
................*..................510..............*..285..........................................650.......*....807...*............#.....
..205.669...768...88........................+59..148............682........#.................3..............376...*.......191...............
.........&....*..%........................................183......*......61................/........657..........163............255........
..674.......46..............392..251....507.................*.248...74..........+...775.97.....222.........%..........135...950.....*.......
....*...........*967..533...*............*......949..245.276...#.........*.....728...................677..137.....*.....*..&........522.....
...367.......196.......$..239..........510.748..*............/...481..722....................800........*........735..268...................
.........442...................111...............752........567...*.........*..........696..%............790................................
.............182....677..613............................/..........814...372.86........*......915*..............799.................*....253
....&....739*........../....*206.........284...........584...427................727..485..........781.992.........-...............619.......
.....603.........................907........*....607......../.............................617............*...=.......986-.............918...
.........819..667..341...........*....#..397................................#........$..................822...20...........359.....43.......
.......&....*...#....*.......*....88.691.........................700.675....910...227........350...&591............301.......$.......*......
..404$..259.......557....876.218...........216.=211.7...=569........*........................=.................320..*....462...480....747...
..........................+.............#..*........*.................=518........................274............@...276........../.........
.......#...904......622..............923....543....969../..................571..778......#888.253..................+.....163.........-679...
295.207.........708......................................942...496....#...*.......*.373@.......*..645...............580.......177...........
................................982*317............304........*.......28.823....994.......370..96........@.=...*675............*.....604....
644.138.522......%......901.................374*..*.........458.....................#135....=..........730.355........955...=.47.277*.......
...*....*.........288..*.............+.433.........240.................317/........................609............#90.*...623...............
.....%..675....87.......110...126.408..*......355.............................@131......110....778...*..519.834.......537.....19........502.
..831............*460........*..........824.....*..751...467.829..........850..........*............365....*................................
..........398..............473....-..........751.....*......*................@.446*....780...........................732....................
.......................#.........333..................170........596...............943......66..186......@...........@.....=................
......124....780.....58.....933........926.../.............693...*..........*828...............*........666.............=..337..............
.......*.........197..........$.......*......67............-...335...........................122...582................197..........328......
.....151...............................763......180....@............890../....835...578..871..........*295..#....%...........-541.$.........
........................153.........-........@.....*...661..*833......*.775.....-...........................40....665...............701.....
..890....252......................544........809..425..............925......................................................................";
        static string inputTask4 = @"Card   1: 72 42 34  7 30  3 25 63 99 15 | 63 30 64 15 72 55 73 32 75 41 37 77 49 51 95 16 25  3 92 18 87  2 71 28 10
Card   2: 52 89 94 79 81 30 58 77 69  2 | 94 77 35 81 96 52 84 85 69 51 78 24  2 41 37 30 44 57 48 14 33 89 58  5 79
Card   3: 93 12 23 20 64 72  3 32 25 27 | 23 35 36 69 38 12 74 57 20 93 72 41 88  6 25 37 32 76 27 64 81 83 40  3 54
Card   4: 68 36 31 91 12 19 75 32 33 52 | 77 75 12 54 32 59 52 36 19 40 55 31 71 11 84 91 16  7 42 95 68 33 47 67 65
Card   5: 68 39 51 95 10 77  5 36 75 99 | 86 94  1 99 96 68 98 77 25 95 32 20 97 75 28  5 10 51  6 36 14 78 66 29 39
Card   6: 60 53 10 26 45 64 31 88 74 21 | 36 35 11 17 18 47 86 59 28  8 32 21 22 31 77 88  9 16 23 74 26 87 75 95 12
Card   7: 95 93 28 80 39 62 74 91 22 63 | 42 39 33 44 94 52 77 95 38 65 84 92 61 91 73  8 96 51 37 71 58  5 81 22 93
Card   8: 76  7 55  3 95 17 24 23 69 47 |  8 41 67 46 29 18  2 82 86 59 88 22 98 25 95 15 57 26 63  3 36 85  7 24 20
Card   9: 63 60 87 27 47 40 26 38 34 57 | 42  1 28 34 12 98 64 37 33 49  3 87 77 46 26 20 38  4 32 79 45 60 35 57 48
Card  10: 30 16 56 17 48 44 65 76 27 61 | 52  8 35 90 41 64  4 55 77  1 49 80 75 95 16 61 85 31 73 97 93  9 76 66 54
Card  11: 28  7 64 33 13 45 97 24 66 51 | 97 46 24 76 28 31 74 65 13 23  1 30 27 15  3 18 12 51 25 33 64 75 66  7 44
Card  12: 57 89 67 77 23 49 12 96 43  4 | 56 67 25  6 29 34 72 23 41 96 89 61 40 60 87 20 57 46  5 49 69 48 47 10 43
Card  13: 27 58 48 17 10 23 40 79 61 71 | 90 57 48 81 17  1 86 58 23  8 21 20  3 35 29 71 53 78 79 15 60 61 41 22 10
Card  14: 16  8 76 31 64 95 61 14 59 58 | 79 48 62 88 99 82 49 52 66 16 30  1  8 29 98 31 91 38 96 55 51 27 65 93 36
Card  15: 46 39 99 29 88 81 26 42 77 75 | 94 85 34 19 99 54 26 32 56 74 29 28 18 47 81 55 79 17 41 45 46 68 77  4 73
Card  16:  7 10 45 37 11 83  2 78 69 73 | 71 21 32 92 31 25 12 61 19  1  7 20 97 43 64 40 16 55 83 51 53 36 38 69 93
Card  17: 37  8 68 43 21 50 25  4 99 63 | 34 57 66  8 88 16 55 62 32  5 43 19 36 18 12 92 10 73 65 56 77 94 44 39 58
Card  18: 72 99 36 80 48 63 77 75 84 25 | 45 16 71 32 72 64 23 48 88 68 75 77 38  8 84 89 79 41 73 10 51 44 47 29 20
Card  19: 69 78 70 25 84 71 48 52 18  6 | 21 84 13 27 55 34  2  3 14 16 35 44 93 62 46  6 70 99 31 10 68 65 78 61 92
Card  20: 72  8 64 15 20 91  9 73 54 83 | 21 48 56 65 17 44 66 20 68 29 63 30 67  7 18 24 32 85 12 60 11 23 70 35 93
Card  21: 86 13 97 67 60 50 89 56 90 78 | 71 74 38 87 92 39 50 80 61 26 15 53 60 72 46 54  6  7 55 19 37  1  9 20 94
Card  22: 99 41 71 28 23 88 93 94  1 37 | 38  6 79  4 26 47 61 84 52  3 70 43 76 35 32 51 11 49 39 72 60 85 89 25 57
Card  23: 85 24 78 46 99 29 75 55 64 70 | 67 71 16 43 83 47 59  7 34 97 17 62 10  2 36 39 37 38 92 58 42  4 84  3 96
Card  24: 55 60 83 42  8 31 14 30 96 50 | 48 30 88 77  4 29 33 46 21 28 44 71 78 99 84  2 73 45 31 85  9 91  1 86 55
Card  25: 86 39 53 63 74 15 23 16 78 95 | 84 10 32 48 56 92 60 99 37 90 27 96 53 98 19 28 85 49 64 45 59 17 41 24 42
Card  26: 85 27 96 10  6 24 16 15 26  1 | 21 62 61 69 22 81 64 56 95 30 11 76 74 31 73 57 89 27 32 68 67  2 98 71 49
Card  27: 72 99 45 96 53 86 22 92 95 49 | 78 59 30 92 66 95 55 23 85 99 24 45 38 53 79 36 18 70 22 98 47 16 76 49 96
Card  28: 21 35 15 99 47 92 32 64 69 97 | 18 64  2 92 96 57 84 37 34 15 32 36 99 97 69 68 35 43 40 73 21 47 83 67 46
Card  29: 40 88 58 51  2 32 95 26 99 17 | 68 23  7 20  9 64 28 26 72 51 17 65 58 88 87 67 95 21 48 63 32  2 40 99 25
Card  30: 99 65 22 27 36  7 71 54 73 98 | 73 87 35 74 45 68  7 80  4 47 65 71 22 42 91 34  5 62 94 60 23 27 96 89 79
Card  31: 64 26 13 16 63 79 86 88 18 28 | 77 25 80 88 79 30 14 13 65 90 31 28 81 60 18 95 11 39 41 93 82 33 92 96 16
Card  32: 56 82 36  7  6 29 33 90 65 96 | 68 59 25 15 28 20 67 16 51 29  3 11 81 63 84 77 44 41 24 30 33 90 61 72 43
Card  33: 23 59 37 55  3 41 28 17 78 32 |  4 71 66 76 89 93 75 91 88 90  3 17 53 73 28 45 37 60 32 23 58 36 40 22 84
Card  34:  2 18 26  6 49 77 64 59 50 66 | 87 18 41 79 54 26  6 22 27 49 82 83 50 38 44 59 81 36 89 66 15 53 42  9 28
Card  35: 81 48 43 63 21 96 91 68 78 39 | 41  7 82 39 99 46 49 29 48 70 91 25 14 54 87  9 96  4 30 76 28 67 40 73 20
Card  36: 15 66 40 86 77 70 64 30  4 85 | 72 83 81 93 12 97 74 37 15 20 84 28 56 73 92 39 77 70 43 55 58 40 69  2 96
Card  37: 38 22 88 47 39 42  8  9 53 48 | 20 87  9 33 28 31 72 42 74 49 79  4 13 44 77 50 54 81 63 65 36 24 64 26 89
Card  38: 28 72 56 37 77 49 58 57 31 85 | 87  1 97 69 89 45 26 91 96 39 79 46 85 49 25 22 18 35 59 38 23 47 67 53  2
Card  39: 23 86 32 13 71 95  2 96 72 55 | 24 54 80 28 63 39 88  6 38 87 70 23 97 18 52 35  1 61 50 29 58  5 93 21 40
Card  40:  7 45 40 49 94 46 42 53 59  4 | 25 57 76 40 81 11  9 77 43 92  1 61 10 30 47 28 50 31 22 12 84 90 80 74 62
Card  41: 60 79  1 38 65 63 91 25 68 16 | 89 62 70 30 21 84 88 72  6 36 27 80 20 35 85 76 96 18 13  2 12 92 41 64 49
Card  42: 74 42 13 34 14 88 36  4 92  2 | 79 91 47 46 32 66 39 40 24  6 52 31 65 22 71  1 60 96 75 16 69 89 26 41 11
Card  43: 54 35 52 10 78 62 14 26 31 61 | 57 55 27 68  8 49 37 70 51 88 17 25 38 11 22 94 64 99 30 12 92 42 69 18 36
Card  44: 89 80 79 10 39 23 71  4 94 31 | 35 81 20 42 63 89 98  5 48 41 15  6 32 56 51 70  3 95 59 87 62 72 18 38  8
Card  45: 57 25  8 54 47 39 88  9 61 97 | 23 30 13 97 27 52 45 51 82  9 99 86 85 92 70 65 43 41 69 12 90 46 39 21 91
Card  46: 74 39 41 36 98 35 30 44 52 88 | 76 42 17 66 81 71 78 40 93 18 45 36 43 29 95 70 57 26 79 28 98 94 33 12 13
Card  47: 70 61 84 72  4 11 63  3 62 97 | 63 70 88  4 18 24 80 81 56 52 84  2 94 67 41 59 77 62 12 38 60 11 92 15 58
Card  48:  1 70 80 88 71 76 31 98 53 27 | 90 85 45 15 13 23 98 59 37 83 89 91 71 63 82 93 35 32  4 16 64 48 10 58 50
Card  49: 26 45 20  8 85  9  6 97 55 42 | 27 18 68 29 74 59 51 60 87 45  6 67 53 10 72 41  2 84 56 92 30 73 71 42 69
Card  50: 69  1 66 37 88 61 90 58 33 20 | 60 23 71 86  8 95 68 11 67 53 20 35 78 29 48 57 63 69 51  9 43 44 81 25 16
Card  51: 50 30 42 54 28 27 66 26 85 76 | 85 69 68 73 18 49 27 20 16 92 57 37 62 65 75 89 22 99  3 94 31  7 48 70 17
Card  52: 10 93 26 70 17 15 51 90 92 47 | 81 32  4 50 34  2 13 94 33  9 31 35 57 17 86 47 98 85 28 46  7 76 42 83 77
Card  53: 83 36 87 78 79 72 20 99 88 58 | 92 61  4 35 17 36 78 87 25  6 26 97 24 11 89 77 71 39 38 96 22 65 19 10 76
Card  54: 90 13 49 20 35  7 27 46 70 19 | 75 50 84 21 47 56 49  1 41 34 78 86 53 24 36 20 64 13 14  2 16 18 65 54 32
Card  55: 54  7 69 14 56 41 42 65 70  2 | 67 30  4 83 16 12 35 13 92 80 39 52 58  8 15  5 43 29 27 75 53 26 50 89 37
Card  56: 30  6 69 51 65 71 79 35 48 98 | 21 70 11 66 54 42 55 99 18  1 56 63 88 39 86 24 46 67 29 15 44 76 65 37 28
Card  57: 84 79 10 11 50 30 36 65 28 19 | 62 97  7 70  5  9  3 47 20 18 52 35 26 48 59 75 89 91 71 32 34 22 72 16 46
Card  58: 78  9  2  4 14 64 43 34  1 31 |  9 78 61 64 74 43 38 46 20 34  6 84 14 69  2 12 36 42  7  4 51  1 37 31 82
Card  59: 45 81  5 80 50 95 82 16 44 99 | 20 10 55 92 49 39  6 90 81 76 35 54 11 82 80 61 68 23 47 60 88  5 99 96 64
Card  60: 81 26 27 19 54 33 40 11  5 90 | 76 49 33 53 54 79 21 27 35 26 56 11 81 80  5 15 50 90 40 48 87 31 24 19 23
Card  61: 70 65 80 25 30  4 12 71 43 85 | 80 71 97 99 90 27 13 20 16 19 10 61 25 43 49 94 39  4 30 70 12 57 65 85 14
Card  62: 91 52 22 30 60 54 67 83 88 34 | 78 68 37 73 69 92 87 48 44 88 13 91 60 12 72 36 54 14 22 61 67 83 30 52 34
Card  63: 94 41 79 25 24  9 10 42 48 49 | 69 63 66 40 53 94 97 82 80 64 48 99  3 79 41 68 62 30  9 74 59 49 20 52 65
Card  64:  6 68  2 74 31 97  4 71 78  1 | 85 31 78 61 12 71 19  6  4 79 87 15 48  1 27  2 14 29 37 30 97 74 94 68 70
Card  65:  3 56 52 75 44 78 94 87 55 60 | 99 61  1 18 76 23 92  2 43 41 37 93 29 22 19 59 53 17 46 38 13 90 34  9 62
Card  66: 42 76 77 85 81 26 27 38 35 23 | 29  6 25 81 85 89 70 65 30 96 44 91 11 15 60 99 87 27 79 54  7 63 26 76 37
Card  67: 94 13 63 52 10 18 38 80 32 70 | 61 52  8 10 55 80 18 93 15 62 63 32 70 42  2  1 38 13 94 25 59 47 30 91  5
Card  68: 91 60 34 79 36 82 31 43 76  9 | 79 76 60 91 98 64 25 15 24  4 40 31 88  9 97 43  7 19 36  3 87 13 82 34 39
Card  69: 93 70 98 45 55 72 95 66 29 54 | 72 26 55 69 71 95 29 54 93 77 98 73 78 35 94 60 30 10 47 89 59 43  2  8 17
Card  70: 25 74 47 31 15 57 13 67 26 28 |  5 47 85 26 45 89  9 94 78 17 50 52 42  4 72 16 23 67 22 73 58 55 70 32 28
Card  71: 56  4 53 46 94 29 83 30 89  7 | 58 63 84 38 92 21 74 69 30  4 78 89 44 93 40 29 17 52  7 68 47 46 96 82 13
Card  72: 40 90 82 26 33 71 61 77  2 95 | 73 49 89 41 99 91 88 56 44 70 52 54 55  4 93 81 85  6 23 29 64 69 26 18  7
Card  73:  5 19  1 59 68 41 42 63 76 98 | 90 44 72 76 67 21 80 69 29 13  8 54 51 35 70 40 52 89 48 78 84 74  3 22  4
Card  74: 80 76 25 96 50 97 31 65 17 26 | 79 15 91  7 89  4 55 26 14 92 76 25 77 96 72 50 37 13 94  2  6 63  3 35 65
Card  75: 48 44 75 19 64 15  7 84 80 23 | 23 47 24  9 28 18 55  5 30 12 88 74 75 68 19 43 57 73 35 62 97 44 72 54  4
Card  76: 24 58 72 12 78  4 47 26 38 37 | 90 93 34 65 88 48 16 56 13 81 51 59 67  6 28 75  8 85 11 74 47 70 77 41 58
Card  77: 69  1  9 22 48 37 92 23 87 89 | 67 45 38 62 90 13 31 34  2 53 23 16 52 27  8 47 54 88 77 78 73 24 32 95 17
Card  78: 32  2 69 81 63 27 71 40 87 64 | 86 75 53 43 29 44  7  4 78 13 15 80 70 76 96 52 18 24 36 49 31  1 19  9 57
Card  79: 77 75 62 44 93 43 58 36 40 65 | 83 16 49 75 86 25 44 81 77 66  6 96 64 54 32 51 11 95 33  5 19  7 30 38 74
Card  80: 27 25 51 76 78 73 32 26 44 13 | 14 28 50 17 59  5 39 74 15 67 33  8 86 32 40 58 72 68 96 66  1 98 31 65 46
Card  81: 23 80 16 89 92 28 94  8 87 15 | 39 41 85 51 12 58 31 81 26 99 17 77 87 91 84 18 21 52 66  3 98 22 54 76 19
Card  82: 11  8 87 49 66 34  7 92 83 28 | 59  5 10 39 26 81 76  9 61 42 18 20 46 17 77 53 78 88 82 15 21  6 75 64 13
Card  83: 55 37 99 54 46 94 32 15 91 24 | 94 70 68 24 52 65 99 91  8 89 32 48 15 76 73 95 55 78  5 96 26 54 46 37 19
Card  84: 23 80 33 41 81 50 57 78 53  6 |  4 78 66 50 72 53 87 99 74 23 81 18 32 57  6 98 80 39 54  5 41 83 14 86 33
Card  85: 76 83 46 92  6 65 73  3 78 28 | 32 59 26 92 83 65 21 46 64 28 61 50  3 11 29 75 36 20 17 76 73  6 78 91 55
Card  86: 56 50 18 82 63 61  9 95 47 59 | 80 79 74  6  5 25 82 97 61 18 63 21 59 11 32 56 49 65  3  9 95 47 54 50 68
Card  87: 15  2 85 45 33  4  9 24 65 58 | 40  2 98 75  9 41 24 85 78  4 65 15 80 45 58 52 33 32 26 35 51 28 14 56  6
Card  88: 93 35 69 57  8 74 47 39 52  4 | 74  8 64 98 80 86 63 91 93 76 52 24 68 15 39 96 57 97 69 78  4 51 47 35 38
Card  89: 91  8 73 99 75 66 31 43 55 92 | 64 43 25 58 48 91 29 66 20 47 72 75 92 45 36 81 73 55  8 33 13 10 31 99  7
Card  90: 64  8 65  3 29 61 74  7 59 53 |  4  8 67 29 20 97 98 39 95 75 45 74 12 87 53  3 65 31  7 61 55 64 26 59 46
Card  91: 39 70 40 95 23 45  2 18 89 30 | 70 12 64 13 14 18 23 56  5 45 76 73 10 54 81  8 94 83 89 40 49 95 79 92 78
Card  92: 53 30 93 85 86 66 34 35 47 37 | 10 44 41 73  6 34 89 92 30 75 99 87 52  4 21 51 45 59 29 78 67 11 17 68 42
Card  93: 95  3 90 96 73 78 58 55 13 61 | 57 37 26 51 68 64 48 54 24 36 56 25 19 15 17 88 73 55 92 11 74 87 14 35  8
Card  94: 35 13 57 75 85 23  8 49 33  5 | 66 76 20 80 21 33 96  5 49 25 23 88 13 54 24 57 32 62 84 78 60 17 91  8 85
Card  95: 43 77  1 95 38 40 32 68 26 89 | 77  7 65 76  1 37 25 26 12 48 29 89 95 28 96 68 38 40 43 58 57 45 32 67  5
Card  96: 90 22 40 75 80 43 86 34 82  7 | 82 89  7 97 86 69 40 75 34 87 16 65 37 55 57 11 19 85 95 83 71 84 35 90 80
Card  97: 67 12 11 51 56 82 43 18 38 94 | 63 72 48 75 95 14 30 15 68 44 19 73 46 67 88 82 85 35  6 84 78 71 40 24 33
Card  98: 89 64 91 94 98 87 74 68 18 49 | 35 54 21 77 75 38 32 45 46 22 44  4 41 78 27  9 93 25 90 48 57 47 68 30 99
Card  99: 36 16 81 35 91 25 86 50 57 17 | 73 75 18 88 87  8 24 11 25 16 36 59 69 81 68 91 72 78 71 66  1 99 26 86 57
Card 100: 52 71 18 60  6 88 27 33 92 29 | 66 61 80 21 25  8 79  7 41 99 95 43 29  4 93 13 55 37 23 30 72 28 57 26 62
Card 101: 40  8  5 79 92 47 17 48 23 77 | 74 57 65 24 79 52 92 43 10  5 50 40 95 90 71 64 34 15 32 41 63 17  7 26 37
Card 102: 64 77 24 30  8 23 98 75 67 66 | 40 17 69 62  3 21 74 30  8 52 81 42 76 68 75 29 72 19 98 50 15 99 92 49 89
Card 103: 34  9  1 49 90 87 55 86 11 82 | 66 39  3 87 52 81 89 41 99 95 38 54 55 50 27 93 30 91 77 20 29 83 65 88  5
Card 104: 34 10 73 24 15 77 88 95 19 65 | 90 62 70 56 14  8 53 17 81 61 72 13 45 86 71 24 74 76 97 87 23 40 94 41  6
Card 105: 73 47 91 81 55 27 43 80 63 25 | 11 31 44 42 17 93 77 12 96 61 35 53 92 51 18 71 38  9 67 75 58  5 88 72 52
Card 106: 45 52 51 29 16 93 66 96 49 43 | 88 25 58 76 34 54  4 20 81  8 47 65  3 90 94 22 18 41 28  9 21 57 26 70 35
Card 107:  1 12 46 25 11 87 80 82 57 65 |  1 12 17 30 11 95 80 19 22 69 46 82 65 29 34 44 62 57 51 87 25 45  3 23 56
Card 108: 78 12 20 25 16 19 30 93 59 75 | 19 59 79 93 12 92  7 16 20 10 64 89  1 87 62 91 58 38 74 37 72 47 60 27 30
Card 109: 73  8 74 89 18 91  7 93 68 94 | 68 25 56 55 48 74 12 91 43 93 18 94 19 65 95 67 54 42  8 52 82 69 89  7 45
Card 110: 40 59 97 13 34  9  1  7 87 28 | 70 97 71  1 60 20 86 40 44 77 87  4  9 16 34 73 38 39 28 59 96 13 21 78  7
Card 111: 29 60 63 68  4  7 45 46 13 90 | 78 32  2 29 86 47 28 14  5 18 31 59 46 68 64 97 45 55 91 63 90 60 92 93  7
Card 112:  9 25 58 91 81 28 52 99 73 13 |  1 95 60 59 10 12 17 78 11 34 41 35  6 49 64 75 82  3 58 67 14 54 57 28 55
Card 113: 73 14 18 93 70 92 90 65  9 91 | 95 69  6 36 80 56 10 33 48 47 34 58 57  7 83 24 37 26 19 86 76 31 15 35 64
Card 114: 37 62 48 26 58 21 65 25 24 78 | 93 40 52 24 25 19 77 83 57 43 38 62 39 21 10 36 76 20 26 60 37 15 16 65 45
Card 115: 48 30 97 47 75 92 54  7 22 50 | 48 21 54 13 78 17 31 75 92 14  7 20 22 97 30 35 11 77 18 47 45 70 50 69  5
Card 116: 82 21 15 60 81 39 29 10 66 22 | 71 66 40 82 65 23 18 29 21 30 68 43 10 60 67 22 11 15 62 39 69 85 31  2 81
Card 117: 54 50 61 78 99 47 26 44 38 87 | 68 89 64 78 39 11 91 24 26 50 45 74 73 27 87 44 82 47 38 33 67 51 13  3 54
Card 118: 37 53 91 15 79 31 74  9 58 80 | 97 70 28 13 11 79  2 50 69 93 94 12  7 54 14 62 65 40 64 22 59 19 90 10 36
Card 119: 72 96 41 97 17 33  4 81 29  7 | 38 29 47 81 20 17 72 25  4 36 24 33 93 30 49  7 34 52 78 28 41 98 96 56 97
Card 120: 64  7 82 45 92 26  6 47 53 70 | 83 53 63  2 90 81 78 69 11 86 68  5 42 98 37 70 59 75 82 44 40 87 55 43 95
Card 121: 93 90 20 87 23 17 67 74 16 50 | 93 40 43 51 65 69 32 39 10 56 22 99 64  7 37  3  4 61  9 63 92 31 70 35 46
Card 122: 90 15 66 36 47 22 34  2 48 74 | 41 76 38  3 37 84 45 57 96 59 67 47 20  4 93 55 80 18  6 58 72 75 21  7 71
Card 123: 36 51 45 54 40 50 99 78 19 69 | 35  1 68 98 51 65 45 83 95 27 78 91 44 22 48 96 33 79 14 77 88 36 26 54 40
Card 124: 52 80  2 38  6 79 69 12 42 84 | 76 82 11 57 42 38 64 65 81 28 93 23 61 69 75 17 22  9 70 41 30 26 24 59 44
Card 125: 28 15 71 21 45 90 69 99 67 19 | 80 25 23 33 88 86 62 21  5 41 66 20 63 47 76 94 99  9  7 18 31 12 68 83 81
Card 126:  6 83 28 97 66 88 20 30 37 98 | 35 15 39  5 68 38 59 90 11 37 24 82 79 54 22 52 87  9 80 49 76  1 29 23 14
Card 127: 62 33 80 58 34 82 79 50 13 35 | 23 89 99 27 56 64 93 66 29  2 41 86 39 36 16 49 88 22 90 17 72 19 44 46 25
Card 128: 31 97 54 98 68 44 66 21 12 64 | 56 17 41 96 13 20 98 49 16 24 58 10 32 19 38 91 69 67  2 57 48 55 47  4 28
Card 129: 11 31 45 56 28 66 97 69 63 95 | 22 52  1 41 90 77 42 39 62  6 12 61 78 10  2 23 59 48 86 96 33 53 50 46  4
Card 130: 18 30 26 93 24 60 31 40 85 83 |  6 83 18 82 24 63 60 41 43 93 22 30 72 85 29 77 12 84 40 16 61 26  9 31 89
Card 131: 32 16 18 79 55 23 85 67 83 62 | 18 67 96 62 98  5 10 94 72 66 50 55 32 63 93 23 90 85 25 79  8 16 30 83 39
Card 132:  9 30 32 89 54  7 68 75 85 44 | 13 30 94 73 50 21 97  9 85 54 16 38  8 84 20 32 41 25 61 66 90 77  7  3 89
Card 133: 33 36 25 13 44 82 70 87 31 42 | 22 36 17 87 74 26 70 80 25 13 27 33 12 52 46 82 86 16 15 44 21 42 31 96 88
Card 134: 26  4 44 47 89 97 62 72 57  2 | 57 39 66 72 68 11 47 91  2  6 71 31 81 62 15 65 63 40 10 89 44 14  3 38 16
Card 135: 74 25 37 34 15 97 79 55 33 36 | 62 30 34 97 74 55 61 86 54 79 32 25 24 33 14 35 26 27 37 89 15 20 36 69 47
Card 136:  5 35  2 29 40 56 30 20 19  4 | 65 26 55 59 94 36 78 12 13  4  6 75 53 45 63 42 67 37 41 89 54 23 86 46 58
Card 137: 56 64 48 82 59 99 72 53  7 71 | 38 16 27 93 80 12 44 40 63 57 73 41 86 42 55 50 37 36 26 51 11 94 83 20  4
Card 138:  9 41  6 31  7 96 54 67 91 60 | 61 78 89 16 92 64 66 30 58 70 85 23 10 97 11 63 83 36 86 25  6 54 45 17 69
Card 139: 34 30 44 64 37 41 46 49 42 94 | 19 12 22 81  8 15 48  2 47 99 93  9 55 98 62 42 37 36 87 77 92 71 34 25 44
Card 140: 88 45 37 47 62 46 79  5 35 18 |  8 94  3 64  5 95 19 15 41 14 43 20 57 63 35 89 69 81 68 18 45 11 62  2 77
Card 141: 20 40 14 84 69 72 77 97 24 98 | 57 75 64 90 71 95 37 21 55 43  4 98 18 41  2 68 30 20 53 13 27 19 38 89 29
Card 142: 31 76 56 50 12 11 83 29 39 27 | 97 80 20 37 49 51 35 71 19 43 84 89 40 13 72 34 59 77 32 98 30 86  9 25 60
Card 143: 46  8 62 31 75 50 56 22 69 93 | 90 69 91 22  7 21 14 40 17 58 71 87 82 95 43 83 93 49 60 39 61 37 26 18 19
Card 144: 56 58 52 82 31 13 94 26 51  8 | 62 36 54 65 59  4 20 63  6  1 44 93 96 48 57 23 18 34 88 17 35 91 28 71 25
Card 145: 66 55 61 68 13 67 94 43 30 40 | 45 42 38 54 56 34  8 76 26 75 58 37 60 83 46 40 12 64 94 13 48 90 77 71 92
Card 146: 48 26 45 13 82 78 42 53 10 43 | 10 71 22 18 29  9 53 16  8 74 59 63 23 24 68 34 51 79 33 70 84 95 15 17 69
Card 147: 72 62 31 87 90 79 85 88 92 66 | 24 99 82 42 28 34 47 55 25  3 73 64 93 19 11 57 53 38 10 48 76 37 27 60 44
Card 148: 93 38 70 11 87 94 65 81 21  6 | 35 68 36 86 40 29 44 12  2 53  5 85 73 31 45 76 80 52 69 56 25 54 14 16 90
Card 149: 31 52 17 65 41  9 66  5 16 93 |  7 86  8 38 87 35 33 73 68 81  1  6  2 77 60 50 62 70 20 18 95  3 97 91 42
Card 150: 11 57 95 18  5 26  4 44 59 38 |  4 13 60 93 28 17 63  1 97 79 51 49 18 23 53 16 86 45  7 21 56 55 39 65 70
Card 151: 39 36 85  7 88 10 72 97 90 27 | 98  6 10 92 12 99 68 82 42 97 75  5 36 46 35 37 38 88 90 29 23 74  9 56 52
Card 152: 62 56 21 95 54  7 59 84 63 67 | 54 68 88 28 93 52 76 62 64 44 70 90  6  7 95 56 96 87 85 21 67 75 27 82 91
Card 153: 62 31 71 79 15 12  9 57 93 91 | 44 16 58  6 49 88 52 14 57 28 23 79 72 40 17 29 18 22 42 81 37 91  4 97  3
Card 154: 53 70 76 62 19 41 52 69  5 24 | 76 52 38 11 19 67 41 23 91 53  5 24 12 16  7 70 65 37 42 22 62  2 20 35 32
Card 155: 79 63 21 73 65 57 18 27 13 87 | 59 70 98 85 22 25 13 21 95 10  4 17  8 79 77 92  3 33 36 64 58 51 84 97 15
Card 156: 38 68 83 76 26 57 90 64  1 15 | 42 71 74  3 13 21 27 75 28 59 91 51 70 57 99 54 39 73  8 30 62 68 85 92 18
Card 157: 60  1 88 97 76 28 81 66 16 39 | 81  2 61 16 45 33 79 71 90  3 26 58 70 54  1 39 86 88 25 48 47 56 24 40 82
Card 158: 88 28 41 16 95 70  5 94  9 51 |  4 83 15 41 63 94 98 45 32 12 39 75 38  1 64 96 18  9 51 71 95 27  6 10 50
Card 159: 30 46 69 86 50 15 56 88 59 70 | 77 65 53 49 12 31 18  7 94 59 70  3 17 79 72 14 74 57 96 37 21 47 58 50 68
Card 160: 86 44 41 13 16 24 67  2 48  7 | 87 26 34 63 10 52 66 97 64 46 33  4 70 53 61 94  8 13  9 39 14 49 30 75 43
Card 161: 15 46 36 78 41 86 87 92 49 80 |  7 61 58 53 56 33 43 75  6 79 52 25 94 66 90 95  1 48  8 68 72 91 42 34 19
Card 162: 27 98 46 22 87 10 97 18  5 58 | 56 21 62 64 72 48 26  4 54 52 14 63 84 59 37 28 73 99 47 44 82 69 71 81 76
Card 163: 65  8 26 79 35 82 18 75 40 76 | 58 67 84  4 33 74 38 80 89  1 99 55 92 94 69 34 48 52 98 42 32 64 54 88 37
Card 164: 99 15 46 52 23 28 13 72 17 78 | 41 59 97 94 79 95 38 18 64 70 96 77 21  9 66 28 78 90 58 29 71 52 11  2 74
Card 165: 73 39 26  4 67 65 79 22 89 78 | 33 79 70 13 65 94 75 17 22 89 26 67 10 86 28  4 71 38 48 19 45 46 15 59 55
Card 166: 62 85 90 76 53 33 99 32 55 71 | 66 28 87 67 26 80 70 57 16 54 97 38 43 74 19 23 60 72 71 92 37 17 61 46 42
Card 167:  2 71 49 13 39 91 35 14 24 23 | 89  2 72 76 55 23 37 24 66 13 75 56  7 14 39 45 91 49 22 17 19 35 47 41 57
Card 168: 71 51  7 15 99 28 95 70 86 57 | 74 42 73 47 96  5 46 39 76 71  1 94 85 41 67  6 12 69 72 98 18 81 36 59 21
Card 169: 96  3 10  7 70 85 44 33 74 28 | 48 91 61  7  3 85 19 26 90 33 74 96 58  4 13 28 40 31 77 70 44 14 41 10 54
Card 170:  6 29 84 58 93 28 12 74 16 81 | 48 30 98 19 52  2 65 78  4 41 56 35 90 92 12 38 50 17 79 45 51 74  5 88 40
Card 171: 80 82 69 36 31 86 39  7 62  9 | 76 65 36 46 83 17 70 42 62 39 38  9 85 94 66  7 31 86 29 19 80 24 79 82 52
Card 172: 40 45 78 95 18 54 11 52 51  8 | 78 23 90 13 55 40 93 64 63 28 62 58 51 74 65 29 25 69 98 96 85 11 45 37 71
Card 173: 52 13 74 71 73  1 40 76 64 23 | 59 26 48 87 63 16 29 90  3 45 57 67 70 22  1 11 51 24 18 93 95 89  7 86 17
Card 174: 16 22 71 10 78 57 89 41 98 29 | 67 52  9 21 19 15 47 55 42 62 25 38 87 97 61 91 44 80  3  4 95 66 23 39 99
Card 175: 56 53  6 45  5 42 22 59 84 87 | 34 97 63 59 62 47 88 50 75 45  5 26 65 52 25 39 87 68  4 42 13 38 33 19 77
Card 176: 90 63 13 55 52  5 58 70 32  3 | 76 25 32 27 26  5 44 80 14  9 98 39 78 43 24 55 99 47 95 36 72 93 74 16 60
Card 177: 43 79 88 49 34 42 69 83 11 94 | 76 34 28 72  8 14 82 74 67 56 17 53 46 81 69 93 73 78 29 10 41  7  2 94 89
Card 178: 39 29 85 95 63 87 52 16 33 90 | 88 76  1 12 81 38 72 77 19 46 11  2 44 85 71 24 57 25 28 69 97 37 98 94 50
Card 179: 82 36 61 27 71 84 93 48 16  8 | 19 81 37  1 69 77 90 91 40 66 26  4 46 61 83 98 25 73 23 10 85 52 58 56 59
Card 180: 10 53 55 47 40 51 28 27  6  8 | 89 18 44 17 32 86 71  1 87 50 33 94 97 98 29 74 66 56 12 52 84 99 75 83 69
Card 181: 79 27 56  9 80 31 37 75 62 15 | 81 20 28 43 83 72 52 90 95 39 25 57 59 13  3 12 70 66 34 78 74 44  6 35 48
Card 182: 48 96 21 97 45  7 73  3 51 46 | 34 10 41 89 46 24 48 38  3 97 31 51 86 77 21 81 22 45 37 43 73 96  7 11 91
Card 183: 62 89 20 66 77 45 14 96 59 93 | 51 14 97 93 78 49 66 71 20 77 79 62 56  3 18 23 45 55 70 39 59 96 32 89 52
Card 184: 79 43 66 27 76 70 21 71 19 20 | 49 79 21 12 66 71 98 45 43 94 65 36 54 92 37 70 82 20 32 61 60 76 19 58 27
Card 185: 91 40 88  1 15 86 47 42  9 25 | 38  5 40 82 15 63 29 25 91  9 10 66 47 42  1 88 81 50 90 86 98 65  7 24 39
Card 186: 93 94 57 29 81 56 67 86 42 12 | 71 79 86 39 72 67 77 12 64 56 93 94 90 34 41 60 81 65 82 29 16 17 42 57 78
Card 187: 97 76 22 51 85 78 13 28 72 48 | 45 13 62 51 88 78 85 93 99 68 84 48 97 38  1 75 76 11 60 72 91 22 70  3 28
Card 188: 88 60 55 48 93 86 11 39 52 40 | 86 96 11 88 55 72 74  1 40  8 52 48 85 61 81 39 17  9 56 69 93 57  7 60 73
Card 189: 55 92 80 81 19  1  5 57 77 91 | 32  2 87 77 64 36 91 65 73 54  3 88 57  4 92  5 55 47  8 96  1 19 81 41 80
Card 190: 97 13 22 50  7 96  9 69 71 87 | 66 85 20 57 83 69  6 41 24 30 33 46 73 62 52 13 59 97  8 16 58 22 76 54 95
Card 191: 30 45 49 52 89 95 81 50 79 54 | 52 22 71 89 63 75 33 80 37 26  7 54 94 83 50 45 32 81 79 62 95 77 19 49 36
Card 192: 19 65 84  6  8 60 11 68 57 98 | 57 11 84 75 67 65 41 45 95 31 15 83 50 20  3 52 98 58  8 51 60 78 77  6 94
Card 193: 23 13  3 52 40 44 18 54 88 63 | 79 71  3 96 76 97 51 39  7 18 65 38 13 99 16 92 37  4 67 42 23 44 24 50 21
Card 194: 14 18 25 52 51 69 40  9 39 10 | 76 98 45 21 53 24 13 62 17 81  6 99 39 60 70 50 30 33 58 49 18 56  2 27 63
Card 195: 89 74 91 81 24 79 99 94 75  5 | 67 36 12 98 11 95 76 63 20 28 38  6 42 87 64 48 10 54 53 58 60 34 35 43 31
Card 196: 29 83  5 90 63 25 84 53 64 72 | 29 95 11 39 81 24 27 48 36 28 87  3 66 65 96 47 77 13 84 21 68 55 51 16 23
Card 197: 84 59 32 44 20 75 28 97 86 81 | 32 23 11  2 55 81 79 84  8 59 40 46 66 94 64 91 97  1 45 58 33 29 20 86 44
Card 198: 23 56 48 77 39  3 49 65 96 58 | 22 60 46 87 84 92 78 79 59 25 58 33 89 23 57 81 64 40 27  9 65  5 61 54  4
Card 199: 68 34 40 51 99 79 71 61  8 91 | 97 46 35 38 20 29 41 84 44  2 72 23 17 65 53 94 66 74  4 13 62 68 21 75  6
Card 200: 64 57 12  2 31 81 51 92 58  5 | 40 39  8 99 23 90  2 41 31 75 32 83  9 82 33 76 35 95  5 84 67  7 48 55 98
Card 201: 94 22 71 33 19 55 39 51 29 44 | 86 59  4 77 67 66 40 37 96 64 34 72 60 30 83 28 57 85 50 31 29 97 38 15 49
Card 202: 60 61 91 66 26 49 86 19 27 97 | 80 21 43 40 64 85 32 42 20 74 84 54 39 62 90 89 11 17 71 59 50 45 51 63 72
Card 203: 41  5 59  9 93 28 82 80 89 24 | 47 88 66 39 26 50 32 24 84 19 42 25 96 86  8 91 20 57 67 14 77 23 16 11 73
Card 204: 85 56 67 47 39 52 96 97 42 72 | 49 58 17 24 62 14 43 30 69 82 34 68 80 50 23 28 84 53 99 22 16 27 83  5 57
Card 205: 54 17 93 26 35  9 61 49 81 42 | 94 14 76 52 15 18 38 41 69 28 16 31 73 32 47 37 71 23 82 90 33 75 24 85 11";

        static int Answer1()
        {
            string[] writtenNumbers = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            int value = 0;
            foreach (string line in inputTask1.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
            {
                string modifiedLine = line;
                for (int i = 0; i < writtenNumbers.Length; i++)
                {
                    modifiedLine = modifiedLine.Replace(writtenNumbers[i], $"{writtenNumbers[i].First()}{i + 1}{writtenNumbers[i].Last()}");
                }

                string numbers = "";
                foreach (char c in modifiedLine)
                {
                    if (char.IsDigit(c))
                    {
                        numbers += c;
                    }
                }

                string lineValue = $"{numbers.First()}{numbers.Last()}";

                value += Convert.ToInt32(lineValue);
            }
            return value;
        }

        static int Answer2Part1()
        {
            int value = 0;

            int maxRed = 12;
            int maxGreen = 13;
            int maxBlue = 14;

            string[] splitValues = new string[] { ":", ";", "," };

            foreach (string line in inputTask2.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
            {
                int id = Convert.ToInt32(line.Substring(0, line.IndexOf(':')).Replace("Game", ""));

                var splits = line.Split(splitValues, StringSplitOptions.RemoveEmptyEntries).Skip(1);

                var green = splits.Where(x => x.Contains("green")).Select(x => x.Replace("green", ""));
                var blue = splits.Where(x => x.Contains("blue")).Select(x => x.Replace("blue", ""));
                var red = splits.Where(x => x.Contains("red")).Select(x => x.Replace("red", ""));

                if (!green.Any(x => Convert.ToInt32(x) > maxGreen) &&
                    !blue.Any(x => Convert.ToInt32(x) > maxBlue) &&
                    !red.Any(x => Convert.ToInt32(x) > maxRed))
                {
                    value += id;
                }
            }
            return value;
        }

        static int Answer2Part2()
        {
            int value = 0;

            string[] splitValues = new string[] { ":", ";", "," };

            foreach (string line in inputTask2.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
            {
                int id = Convert.ToInt32(line.Substring(0, line.IndexOf(':')).Replace("Game", ""));

                var splits = line.Split(splitValues, StringSplitOptions.RemoveEmptyEntries).Skip(1);

                var green = splits.Where(x => x.Contains("green")).Select(x => Convert.ToInt32(x.Replace("green", "")));
                var blue = splits.Where(x => x.Contains("blue")).Select(x => Convert.ToInt32(x.Replace("blue", "")));
                var red = splits.Where(x => x.Contains("red")).Select(x => Convert.ToInt32(x.Replace("red", "")));

                var a = green.Max();
                int lineValue = green.Max() * blue.Max() * red.Max();
                value += lineValue;
            }
            return value;
        }

        static int Answer3Part1()
        {
            int value = 0;

            var lineArray = inputTask3.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            List<(int xPos, int yPos)> symbolPositions = new List<(int xPos, int yPos)>();
            List<(int value, int xStartPos, int xEndPos, int yPos)> numberPositions = new List<(int value, int xStartPos, int xEndPos, int yPos)>();

            for (int i = 0; i < lineArray.Length; i++)
            {
                string line = lineArray[i];

                int indexStartNumber = -1;
                string currentNumber = "";

                for (int j = 0; j < line.Length; j++)
                {
                    if (char.IsDigit(line[j]))
                    {
                        indexStartNumber = indexStartNumber == -1 ? indexStartNumber = j : indexStartNumber;
                        currentNumber += line[j];

                        // get numbers at the top most right side
                        if (j == line.Length - 1)
                        {
                            numberPositions.Add((Convert.ToInt32(currentNumber), indexStartNumber, j, i));
                            indexStartNumber = -1;
                            currentNumber = "";
                        }
                    }
                    else
                    {
                        if (currentNumber != "")
                        {
                            numberPositions.Add((Convert.ToInt32(currentNumber), indexStartNumber, j - 1, i));
                            indexStartNumber = -1;
                            currentNumber = "";
                        }

                        if (line[j] != '.')
                        {
                            symbolPositions.Add((j, i));
                        }
                    }
                }
            }

            var validNumbers = numberPositions.Where(number =>
            {
                int numStartX = number.xStartPos - 1;
                int numEndX = number.xEndPos + 1;
                int numStartY = number.yPos - 1;
                int numEndY = number.yPos + 1;

                return symbolPositions.Any(symbol =>
                  {
                      int symX = symbol.xPos;
                      int symY = symbol.yPos;

                      bool containsX = (symX >= numStartX && symX <= numEndX);
                      bool containsY = (symY >= numStartY && symY <= numEndY);
                      return containsX && containsY;
                  });
            });

            value = validNumbers.Sum(x => x.value);
            return value;
        }

        static int Answer3Part2()
        {
            int value = 0;

            var lineArray = inputTask3.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            List<(int xPos, int yPos)> gearPositions = new List<(int xPos, int yPos)>();
            List<(int value, int xStartPos, int xEndPos, int yPos)> numberPositions = new List<(int value, int xStartPos, int xEndPos, int yPos)>();

            for (int i = 0; i < lineArray.Length; i++)
            {
                string line = lineArray[i];

                int indexStartNumber = -1;
                string currentNumber = "";

                for (int j = 0; j < line.Length; j++)
                {
                    if (char.IsDigit(line[j]))
                    {
                        indexStartNumber = indexStartNumber == -1 ? indexStartNumber = j : indexStartNumber;
                        currentNumber += line[j];

                        // get numbers at the top most right side
                        if (j == line.Length - 1)
                        {
                            numberPositions.Add((Convert.ToInt32(currentNumber), indexStartNumber, j, i));
                            indexStartNumber = -1;
                            currentNumber = "";
                        }
                    }
                    else
                    {
                        if (currentNumber != "")
                        {
                            numberPositions.Add((Convert.ToInt32(currentNumber), indexStartNumber, j - 1, i));
                            indexStartNumber = -1;
                            currentNumber = "";
                        }

                        if (line[j] == '*')
                        {
                            gearPositions.Add((j, i));
                        }
                    }
                }
            }

            foreach (var gear in gearPositions)
            {
                int gearX = gear.xPos;
                int gearY = gear.yPos;

                var validNumbers = numberPositions.Where(number =>
                {
                    int numStartX = number.xStartPos - 1;
                    int numEndX = number.xEndPos + 1;
                    int numStartY = number.yPos - 1;
                    int numEndY = number.yPos + 1;

                    bool containsX = (gearX >= numStartX && gearX <= numEndX);
                    bool containsY = (gearY >= numStartY && gearY <= numEndY);
                    return containsX && containsY;
                });

                if (validNumbers.Count() > 1)
                {
                    int newValue = 1;

                    foreach (var item in validNumbers)
                    {
                        newValue *= item.value;
                    }

                    value += newValue;
                }
            }

            return value;
        }

        static int Answer4Part1()
        {
            int value = 0;

            var lineArray = inputTask3.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            List<(int xPos, int yPos)> gearPositions = new List<(int xPos, int yPos)>();
            List<(int value, int xStartPos, int xEndPos, int yPos)> numberPositions = new List<(int value, int xStartPos, int xEndPos, int yPos)>();

            for (int i = 0; i < lineArray.Length; i++)
            {
                string line = lineArray[i];

                int indexStartNumber = -1;
                string currentNumber = "";

                for (int j = 0; j < line.Length; j++)
                {
                    if (char.IsDigit(line[j]))
                    {
                        indexStartNumber = indexStartNumber == -1 ? indexStartNumber = j : indexStartNumber;
                        currentNumber += line[j];

                        // get numbers at the top most right side
                        if (j == line.Length - 1)
                        {
                            numberPositions.Add((Convert.ToInt32(currentNumber), indexStartNumber, j, i));
                            indexStartNumber = -1;
                            currentNumber = "";
                        }
                    }
                    else
                    {
                        if (currentNumber != "")
                        {
                            numberPositions.Add((Convert.ToInt32(currentNumber), indexStartNumber, j - 1, i));
                            indexStartNumber = -1;
                            currentNumber = "";
                        }

                        if (line[j] == '*')
                        {
                            gearPositions.Add((j, i));
                        }
                    }
                }
            }

            foreach (var gear in gearPositions)
            {
                int gearX = gear.xPos;
                int gearY = gear.yPos;

                var validNumbers = numberPositions.Where(number =>
                {
                    int numStartX = number.xStartPos - 1;
                    int numEndX = number.xEndPos + 1;
                    int numStartY = number.yPos - 1;
                    int numEndY = number.yPos + 1;

                    bool containsX = (gearX >= numStartX && gearX <= numEndX);
                    bool containsY = (gearY >= numStartY && gearY <= numEndY);
                    return containsX && containsY;
                });

                if (validNumbers.Count() > 1)
                {
                    int newValue = 1;

                    foreach (var item in validNumbers)
                    {
                        newValue *= item.value;
                    }

                    value += newValue;
                }
            }

            return value;
        }


        static Int64 Answer4Part2()
        {
            Int64 value = 0;

            var lineArray = inputTask4.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            string[] splitValues = new string[] { ":", " " };

            Dictionary<int, Int64> cardCopies = new Dictionary<int, Int64>();

            for (int i = 0; i < lineArray.Length; i++)
            {
                cardCopies.Add(i, 1);
            }

            for (int i = 0; i < lineArray.Length; i++)
            {
                string line = lineArray[i];

                List<Int64> winningNumbers = new List<Int64>();
                List<Int64> havingNumbers = new List<Int64>();

                int divideIndex = line.IndexOf('|');

                winningNumbers = line.Substring(0, divideIndex).
                    Split(splitValues, StringSplitOptions.RemoveEmptyEntries).Skip(2).
                    Select(x => Convert.ToInt64(x)).ToList();
                havingNumbers = line.Substring(divideIndex + 1, line.Length - divideIndex - 1).
                    Split(splitValues, StringSplitOptions.RemoveEmptyEntries).
                    Select(x => Convert.ToInt64(x)).ToList();

                int countWins = havingNumbers.Where(x => winningNumbers.Any(y => y == x)).Count();

                int added = 0;

                Console.WriteLine($"Wins: {countWins}");
                for (int j = i + 1; j < cardCopies.Count && countWins > 0 && added < countWins; j++)
                {
                    Console.WriteLine($"{i}: {cardCopies[i]} | {j}: {cardCopies[j]}");
                    Console.WriteLine();

                    cardCopies[j] += cardCopies[i];
                    added++;

                    Console.WriteLine($"{i}: {cardCopies[i]} | {j}: {cardCopies[j]}");
                    Console.WriteLine();
                }
            }

            return cardCopies.Values.Sum();
        }

    }
}
