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

    }
}
