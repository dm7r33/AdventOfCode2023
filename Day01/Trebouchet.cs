﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AoC.Day01
{
    internal class Trebouchet
    {
        public static void Start()
        {
            string input = "xt36five77\r\ntwo8five6zfrtjj\r\neightthree8fiveqjgsdzgnnineeight\r\n7chmvlhnpfive\r\n1tcrgthmeight5mssseight\r\neightoneqxspfzjk4zpfour\r\nfdbtmkhdfzrck9kxckbnft\r\n9six9\r\ngoneightczdzjk18589\r\n41two3eightfscdmqjhdhtvsixld\r\nt8929\r\nfourtwoxsxqqmqf3sixfoursixmmjhdlx\r\nbcbsfd14cjg\r\n95three6threendpqpjmbpcblone\r\ntdmvthreeonefive8574\r\n5eight82sixtwonev\r\nninemg2shhmsqh\r\nthmlz4\r\nxtxjmm2tbbntrmdqxpkdjgh1vzjvtvg7nine\r\nvf19fourddfsvmzeight9\r\nmmg6fivegcthdonesix1eight\r\n7rzzdknxtbxdchsdfrkfivenjtbrjj\r\n2sdzxhxp\r\nvzvkjvngfjsxmponep9jppnqnbt8jtwo\r\n85fourfivetwo6xvhfxone9\r\nfivecgtwotwo3oneighth\r\npbmninesixzcqs5\r\nztlhxfmr4mcjnd3two\r\nnfr27zdxchz\r\nsgljlqlcxsnjgppxgqxppqszzgbp7\r\nfive78eightthree\r\nmleightwo68\r\nthreemnnbjncqq68fourmjdfqzqxbdqvfftggf\r\ntwofive35llpqrhptnv\r\npslmgrznfzt823sevennx55\r\n72fivesevenvnxpkoneightgdm\r\n1sixfdjtgxbflfkvv\r\n77three9\r\nfive6skbsrr\r\nfjvlsthreeffzbjlsm2\r\n6dpkrlbxfdv5nine1499\r\njvt9one28nine29\r\n57pbgvccprdgnine49three\r\nqmthreekcsttzmgd1nineone7dvhsjg\r\neightqpfhvqnpbbrbmsz76\r\nvvqjsevenfourhmdn45\r\n2eightxgkdtdkfbtcjgrlthreefivekm2\r\nrfpklsh1threenine\r\nnrhbjqpxssmqbkdbzg2\r\n556ghndxkrg9\r\n3six8\r\nzhkkgqllq9eightninebspgktnh1krfbzdcthreekzxzgszgpd\r\n933five\r\nsixsix5qmbqd\r\n7sevenxckssckcrqnpmfiverqtcdclnkzpztt\r\n5eightpdsvjknine813tnz\r\nk81one\r\n6threegsx48\r\nthree3xbqvcfgjjfsixfiveone779\r\nthreenjtlxnonexqhv1\r\n5ninefourtwofsqdbchtpkfiveninencsdrnvnbf\r\nvdveightsixthree1\r\n2mrxnnqngfmshdz\r\nqfourmjpltwolblkzlkdfr41vmskjgrqkv\r\n8hbjcnseighttwoseven\r\n28lvggdhbjgqth\r\nnineshpzfshzm68ttlqbqxxrvdxrkvdkbcnfdkrhcqpqrfmpxtwo\r\n9hhfninefourfiveczdbrn1\r\n2dpzvd39eightwohjc\r\n3zrhnzvq79fourxgldtbthree5\r\ntwo1716\r\nbgkfjkeightsevenf9gclhlprxlk3\r\nnbf2rdglrfourthree86xfpqckg\r\nhslr84mkdcqpl3qtszqfngthreeonenine\r\n7bhgqcphnb2fpjrbvrlstvghqbkfive1\r\n6lkfdcddkbsevenxsixseven2fsg2eightwos\r\n3xjprzkdsckltdone\r\n1qbkshbrcddjtjz4jhrdmpnrq3mmfive\r\n27five3sevenfourjhhv\r\n5fivevhkttflkone4\r\n5jcthxvhglfourkjrhfour\r\n3lbgzfkljfzkf3\r\n9tmpczsvskqqtveight1\r\nkfrjhgsixfive9three1\r\nonesixpdf8onethree1\r\nonesixnine5\r\n1lscknhb\r\nfourhrnmcfgpzffhdtbdcpdbxqh3\r\ntwoffcbgcjnsix667\r\nsevenfc14\r\n8kzzrbz2threecclhhjn1l\r\nkqqpzbbqkchmkdl46twothree453\r\n8two3jqxmnz\r\neightpszqltlncjpfrdfzffltnthree4\r\neight8eightsixdcgqnbvt1lbhlchdzkf8j\r\n64nine\r\n3twofivetwosevenfour9\r\nlhlntlsixtwojqhsevenone74\r\n2242eight865p\r\ndnhfbgzcvsx5krv26\r\nszdnjvh9\r\nhrzczjbfphxvjqs8one19five2six\r\nlvvkjjvgcjbkhbdnf6ninesqgqhthseventbkzhjbnrb\r\ncrmcpjhfmgeighteight316\r\nvmfqlrnjjnv7fourkqbsfsnnqxfqsixthreesix\r\n7sevensj9919one\r\nhrvtbr2lqkkhn25three318\r\nrngggthlrfoursix2twopv\r\n3srcpjlqt43eighthscbffksixfoursix\r\n885sixbftpfive\r\nqpfkxbqfph9sevenc2\r\n9zrtbhztseven\r\n5bcgdvdtzjjbseven41nineeight\r\ntwo3szknm\r\nklfivethreenine2qdpbp4eightwoqf\r\n1b\r\n8llkrslcbcsfivecqclmfrxbkzfive\r\ntwoseven1\r\nsix3ninefivehtxjqjgv6onepkfgjcczft5\r\noneskjsh5jmnhsxhfoureightfourcml\r\nthjptkn9rpjkbkvgm2\r\nglpbbfjgfivep1696xhcprcqxone\r\n5fivegnsbzt8gtxvhfmt46\r\nfivefoursevenjkxqlcx7onenine\r\nlfourghzdksztjmfour4threepdnfsz6\r\ntwo7one\r\n1onesixdzh\r\n7ftphkqlonesxsrlgkczjthreefive3nine\r\n62ninefivefkbmhvlltfourtwo2one\r\nrgoneighttwortjczm24seven\r\nchqxcv3fdqnjngqkkkrvlcgtdfdsvztx\r\nthree2dvfpsgjfgs16fmvninefourfrvg\r\nfive4bgbfrj52\r\n98sixsevenfourzdsfjddbmbrffkt1two\r\nnine9xhkcmmvb81onehsmxclb\r\n6146four\r\nslmhsix4hhtrdfdjpk2fiveonec\r\n1oneightd\r\n86sevendgdbnrvgjnmtxrmqtt\r\nsix56three2hslccxbnzpmbrctd4\r\nseven8nine3fiveddvpdjgqrjtwovhbdmtz\r\nfive32\r\n769three1\r\nmdcmrbj19\r\nthreethreevc6bknnspdvbfzsevenghqnkxnhfxjf\r\nsevensevenzvqkvvgzn12two9bfzfpxjhfslqs\r\n8mmqrvzklbfivenineeightwohnp\r\nzngczscnv8threesevenfourtwo\r\n695eight8szhqcklnc1\r\nsevenjvnfbbnnine9ninefour64two\r\nfour5threelqtwoxhvhjnkgz2\r\nztnzbgmtdtwonineeight3\r\ntwosxfour6xsshbnhsixsix1\r\nthreesevendmfivesevendxhsdhsevenqnrvfrgpfl5\r\n71dbpsk4\r\neightxqzh1clmrdljnxh\r\njqjthreetwo3\r\n23sixhsvmstwofive\r\nmhvttrxpllkfpxzcfvjtpkfsgd21jtrcrgp\r\n1lcqlznsbdzksklm38frfhdpt\r\n8vjtzvxvfive\r\n9xbcgqhdclrzdnzspllpfrqhnxztftninethree1\r\nseven5two\r\nfourj5ldxlnine\r\nsixtwosix73jjtrvt\r\n9qqbmccrg8xdgcqmnine84\r\nfivedmsdlsfour2rmjxqthxfcsgkqgsxxqbtwonesj\r\none631p\r\n6x2\r\n93nptkkseightkkgnsnqkpfourone\r\n173\r\neighteightvzvxr2pqknnccxqkznc\r\nftbsixnine4\r\nfiverpz9ldmbrqhg\r\n7pzbjtnqcfour4319eightcxpgl\r\ntchdxgqsqeight8ftllckrz1\r\nkz2five\r\nscgflstwo6zzdxdcs\r\n535svzdxtwo4\r\n7fourone2\r\nkqczhqqttf74seven\r\nninesixnttqqzmdg264\r\nsevenfourthree2one9\r\neight1rnnsppqbjzv7jknltmlb2\r\n6eighteight5cljzvzdtqq8sqftf\r\nninebnpxdqs1\r\nseven2nineeight\r\nhjnnqsnfftjstkrlknvlqlkfsdbgz8\r\nrcbhxcfmkc3ptnt2\r\nthreesix378twostfsjjvmnseven\r\nhllssqjbc41\r\nsix9zbkrrvmxngjone5xqjbxcrkhzr\r\nnineone57\r\n3pls\r\nsfcdbhkdrpkdrtxtvlkqfiveqvbxhvm8\r\nfourthreemeight7nine9\r\nfive5fivesfnxfour\r\nh3two2sixgkninetwo1\r\n53ccblnvbqhjxgbxrs1tk\r\ntwotwofxvcmsld2zbjlqzvgzkqvnthfvsftwo1\r\neightninevdxxdglskbfzz8sevenfour8\r\nflhjjt6seveneightlqpfvnpxvthreesix\r\nthreefiveonegpcjjvv6fourseven\r\n9pbxlqdkprzcxp\r\ncblkxjmpgrfk5\r\nqbntftctnine5five3bsevenbskhvtm\r\n7eightsix3threehzn\r\n5nhndlxkthreeseventwocdvnhzrcszhd\r\nsix5onekbctwo\r\nfivezhtlpveightvdfltnxpvrzmczdzb9q\r\nnine9xsfq8vtdpmcfgm2\r\nonesl8mqzgdrstwofour\r\n4onedqtrcc58ghlgxqjlbv\r\n132zvtptdrqt\r\nftwone1tkzzthvdsevenseventtgvqnbzf\r\nprxrsfvdbt73zblz6four84seven\r\nonefive1xllptjtwothreehsdlgrmjssfgk\r\ntwofiveeight781mgjxgzlmgkv\r\n483fbgsx5\r\nfour82onefour\r\n229683five\r\n2onevncxhvscnbtngbzlbbpdnnntr\r\n275cpjnine\r\nj4threefour7dzqleight\r\nddgmsvmfz7brjdxt5\r\nsevenfzjtxjtbmj8fivefive6\r\ntqprcctwofive8sixzmgvphmdsmjtwocbpqc\r\nsevenseven4fourbcscfcprcr5647\r\ntghsix8\r\ntwo83six9sfp99\r\nfourthreefive3seventwo\r\n7threepx\r\noneeight69sixgdzbbmlsh\r\n23onelrdvbzljtcdjqckntwo7\r\nsix8onefivepgs\r\n83gnxnjgvdr2four5nine6\r\nlgfcvptthreesixthreeeightthree23\r\nseven8gsqznnpb3\r\ndqr478fivezxtwo\r\n4cgkjbl261\r\npnjeight84twodnhh4\r\nzeightwozhxshspt45\r\n8rzkpmzlvszvdvonesixeight\r\ntwotwothreeseven95threethree\r\nsixbr293sixthreesixnine\r\n3sixsixthree9\r\nq17ninenineseven8\r\njmhbhqjxvc72qsrhzzpnljeight775\r\n456jnrtpfseven\r\ngjcbnbdkt94dsjrgdq1\r\nfive56g6\r\nrvjq8dkngcfjdd\r\ntwofive43\r\nsixzz9threektkqmfq4gkxxzbg\r\n2four7four\r\nfour3eightsvmnfive6\r\nninelvxcxdrxk1mvhtptlpqvff\r\nqrbtlxbkdrjzkznqp6\r\nz2xdrtqzzrbt9five3five5\r\ntwoeightsevenfive83\r\n73lzgb1\r\noneseventwotwothreemr4dfkjlgshjzvlxqqoneightvvr\r\n5twonvhrbtgfxdlvxrgnpkeightzjpd1\r\ntwotwo6rdfc\r\nsix84sevenfschptts1fg7\r\n8kzqv\r\nhnbjfivettpzkb8six\r\nnine8zcrzgqntworxnj2three5\r\n1qbjtsqqrttwones\r\ngnjmvqrhnsfive5prbzfsjteightqgfcx2one\r\nfivefour8btcrpntwo6oneeight\r\nkfxbxn4283kcjpkbskshjdss9\r\n3threethreeh\r\nbmzjktnnrl8fcmmbtgzkj\r\nvhnine84seventwonine\r\ngq639rhqlbzp21qbseven\r\n6rnineptdmntjsix6cnhhbcn\r\nsixscrdone3mhgnmflzxftwonvkxvrftqcxzcfhdgxlvreightwos\r\n6nine6gngneightlvqmmjjtdkrklqbthffhtwothree\r\nbsn4rrgvrjdddhdfsvsffbqnrsbvtfive\r\ntwozflqcsix53jcsc5twohdeightwofb\r\n73rx\r\nxldqxlmfcdrnthree47tz6\r\nfoursix6ksrzponeonepdbfpjzspp88\r\nczvdzccj9nine7\r\n92one\r\n9one8three\r\nonevfzkmmcrtwotwo2five\r\n8eighttwo6xpfxtvvpx\r\n83four9\r\n3fourdmtqtvqthree2ztvvdjzmfc\r\n8fourpb7jjlcbkxkxfthree44\r\n9cchfourltlxpbjpdrdplrqgrqpk1\r\nfiveeightxlxmr5\r\nbgrczrdsfrcfrpkprdncbkd55qnhjnzkbpninekbmgnlqgmxfqgndc\r\n6jhcjhb57sfive8oner\r\nsix6twofive3ckthree3\r\nxfxkfourtwokqcpvhzjjzsrxjm6\r\nfour85\r\np3foureight3rl\r\nf6four2eight295\r\n1onevonelslgmbq\r\npzj6pmjone94\r\nbkmcjnllrmcfpmqckl3fivenljfgeightvrjfb\r\nkgsczqtwo8qnjhtpfltonepvfive\r\nfourfive5pfnlnjqd\r\nvgrsfxtkcxfstsevennine89\r\nnjkblck4phphvmq7\r\nghflplsgkljsfk5\r\nrtbm32lntjflptp435twosmtb\r\n45four\r\nfiveone41pqgcjt\r\nthreesdnllrxbxmhtcmjvdktqqkzs1\r\n5one14zmxblkh3\r\n4mzzqpmsfour5pnzonerdseven\r\n9bhcxsnxdv7\r\ntwoxxjnsxxjxfnrtnknseven29c\r\nfour54gkcrncmjtpvfbdqr\r\nmmvgl8onekzq\r\ntprfvqnine54rqjkchkxtcrk6gxjgbfqpxg1\r\nthreeghtxbhkkrvxxcrvslhnvczxnine5four4\r\nbkrkeight4jvjvmnine\r\nsevensevenmphmhvhtjxcdcrcgbdvlmcr6mczlh\r\neight74seveneight5eight4one\r\nbspq9fiveklkbeighttwo\r\n51four\r\nsevent79zngvzhhlxjrnrbkvnine\r\nsix3threepsjhtfoureight9\r\n44mvfhcthpbv\r\n3fourmrdzqlvb63hrzhqxc\r\n7fivesixcnxfourpfour\r\ncsix4\r\nqqtjk43\r\neightnhqpxttth9ddbfjpqjmfour83three\r\nslx6fdm9bspmbxdqjfmkhr\r\nstlxrvseven1gnmnqrnlthreenine\r\n56zjfdrb\r\nsbcxqp8\r\n7eightsix9eightseventwo\r\n7twosixfour\r\n1eight6\r\ntwor59eightfourkpsix\r\n571fivefdpntmjqgnineftpjtkh5\r\ntwo7nsdz\r\npmf5twoseven4prgqz\r\n7vfmvlgtvkbxnq\r\neightstdrhhtctthree61fourbmcvhmxtkdhcltxpr7\r\nfdjcssixninetdgtbkgj4snzpqlninehvvkthree\r\n122pqtcthreesixeight8\r\nhfztkh2ksjnj43nine\r\nsdlnm59onekdbdrdksixktk37\r\n4mf114\r\n8foursixninetwoxbcnq\r\nvbhspqrkvcvpfour68xncb3kdbr\r\neight841\r\n2fdr7fivehtnvbk7nine34\r\neightsixone1qzp4nxzrslmzrsix\r\ntwo3zdjntkkcmdpheightfive\r\n44one\r\n17txlqkttvtzhzkjeightcqtpqzxlktxm\r\ntwo8xcvpzppmzntzr\r\npbqeightwoncjsvrlzrkspcnqsrrfivefour5\r\n9foursix1onevflhjngtthree\r\ngp3qjmnsksn3nineeight4\r\n39fdsdqonefleightwopsp\r\n2dfzsfssnpbzfour\r\nstzzclzgskgbztvrfqgbrms6\r\n5zpq81threegdg\r\n6three9ninethreeeightsevenninehhgqhxfhlv\r\n1tqftcgtwo\r\nzpkrjxfpzf5jmpqvxrgp6threexbjlzclxpneightscbrsgnine\r\ntwo4bmlztrzn1\r\nseven9klmsfmjtjr7sph\r\nsixsix4\r\nstldx46three15four98\r\ngthb7nine\r\nlninethreebrzzntwo4\r\n6fvhgpqj5sevencgmm\r\n75two7qktbnpcxtk\r\nfbkzzsixgshhmzdgt9\r\nxfivenineseven1dtzsfive78\r\nfour3ptvfmkkhzjsix\r\nj9txxgmsvxx\r\nseven9lmxhzthbnbbxjmbqkpsntbfourone\r\n712fourlqknine4\r\nxlpnrk64qnjjvszbtkgktbn\r\nlznpdmrcxmzhsjqkc2cjm3zcx\r\n615sevensix\r\nphgjnmqfsqgjtqvzhpc3234qpkpjmxbfr\r\ntnrtmcdljzq1three62\r\nbcndkzgzp5sixhflsix3lgc\r\ndqgmbkxlv4onetwo\r\nfreightwomsix916zrcsjgkktprb91\r\nfourbcmprdvkbl9vxzfkcjfsqdlbndmrsq\r\nsevenninezpblthreesix2threeqrcdpjqjgm5\r\n5jnnine\r\nj9fivesix1zhplxlvxsninefour\r\ndm68htnmqdsnzjvqrrj\r\n8four9pfvjjhrbzmlvhvtseven\r\ntwo256six6qdpldblvleight\r\nninecprgdrmc2eight91mggqdvhcf\r\nsqbccsh81t\r\n1twovfhbngpggbgff8eight\r\nbxdstkqnbhkvt2three2fg29\r\none7threehxcttwosixfourpx\r\nbrnine1nineone\r\n6fffrqfjprmdx6sixseven\r\n7four4fourx8sixfour\r\n951seveneightnine\r\nfivefoursix5tg6dpdxrckdh\r\n829schqjxjdxncs6\r\nseven1twockldvjsbeight\r\ncsjv58dshcsdrkgsixrdl\r\nnineeightstjnxcgzbxrldsevenfour857\r\noneqpndxmthreemnmlnqnffv7\r\ntwotwo8qkdfcxvd253bhd\r\nsevenfour3\r\nt2sevenfgmjjrg63fourrvlz\r\n4six9fivelbkzffrvsoneightxsj\r\nnkkdsbp7kkjchhfckqqxfourthree9\r\n7eightone4fiveninevxtrmbhfbrone\r\nonemjzfsvsbh2vmsxdmcncjlnvtsqszv\r\neight26\r\nsixseven7four\r\ncpkzctmhpmpgtwoqfeight79\r\nvplxpx9tndmcpsone2\r\neightone2bqlmdmf\r\n8sevenfivetwod5one\r\nfxmhpcdckl5czfcmeight\r\n9216gdptpmninetkfjszftzdfive\r\nninefivemrvmdt5nshfxgg5\r\n9qclonefive91\r\nsix28ninethreefive8two\r\n76five\r\nnjdtpktmsqvbfourv9mmonesix\r\n5qxckljjpninedstsfdthreevfrsmtn3\r\ntzrrbjlbq7eight\r\nbzl5\r\n3eightsrnlmlvhtwo\r\nvthqnine1zfive2six6four\r\ncseight1oneone\r\nmgnkflp4grkdrrrtfzmjkbtblfivebgcrmgggxjgkm3\r\n5three1vfrseveneight\r\nseven42seven178\r\n8bnrrzbbvghcqdbtwo\r\nfivegxdzcmbzsix6sktwo2dp5\r\nxqdtmb2sevenxpvdlfsqqkgfxqjqq8468\r\nrscsljnnkd2seven\r\nmzeightwo49ngtzr\r\nthreesk3four3five\r\n7shzxkjkgrt71\r\nnxcnnmkqgv1mdmxtkjtwo9bhbbfive\r\nkdxmcg578six7nxqqbm4ddsxzxmtkq\r\n8rjdkmqfivevpfthbjkbt9mnine\r\n5pxfive\r\nhgnfjtwofive2fxxeightmx\r\npxpqvld69\r\nonesixtxmxttxqfour1rxfrvsgdsveight\r\n95nine9onetwo\r\n48ftnmcxrmxc2vqsgrsqskzs\r\none4threeseventhree86\r\none9ninensqxone5zqfvmpd6eightwozgb\r\n527two3croneeight\r\nsixzdzfour291eight\r\n5vzlblhll42hnrrrjj\r\nxzdkkpseven9one1vlsixfour\r\n4tbzbrthree\r\n8hceighthtd\r\n9four4\r\neighteight7eight6hfthree\r\n6fourbbx1\r\n5onepfzgneightsixxb\r\nxzrjpnfvxr61\r\ntwo1ninenine6pbhkzzgjq6\r\nsdltwonecbbffldnfdlkh131ggkrqqg\r\nkxrzqltp3vfh39\r\nnine79djhzhhgxvglg\r\n5four1one833\r\n1twosevenseven3three\r\n4nineseven\r\nthree42kzqllpf\r\nzkxflrctvsevengkpnqkrrj2\r\n6oneleight9ncnmxbrnkf\r\nqthreenine4vpbzzzfnine\r\n792\r\nhjmn85vtfjgtqv\r\none3sblncblnvf\r\nssxxddpqbdznrczqgsix64three4\r\n2four4fourtbeighttmm\r\nfournineeightfive1twofkjcsrklpxlsdvxnt7\r\nlrlzz8eightmpspsk3nineseveneightnine\r\nv4\r\neight9gfzone\r\njscpppmpnfkhcxlj1pbtbltmj6one5\r\n8nqrmzrbvzrnine\r\ntwo34m73twoklqqdlcrrh1\r\n7fourtmpxnf\r\ntwocpbznkqnqsixt86\r\n81sevenfsdldftgzvnhhhf\r\nggntprxxqrpknineeight8fourlmvsr5\r\nsevenztwoseventfour7eight\r\nfkcbvhmqqk1sevenseventwoseventhree\r\nthree6ltvtkkhgdpsixsixsltgdngvrttwokz\r\n2fourv\r\nc29fsczzfiveqmrfivejbglcqhl6\r\n4two3\r\nnine2kphnrztjltxgq1sevenone\r\nlpbcgone8\r\nvcznvhllrbfx4275\r\nfhlsdjmppnrgqhqqxt921\r\n4four2sqzzcvh\r\n19nbcvlmhlkqfshhckzkzpqbxfour\r\nseven19\r\n6xprmkgfgntwo4bqk\r\nthreexf5threefive4\r\n3fqone\r\n5g2x68cfghcmtwo8\r\n1fourq\r\npflnjchgnine25one5eightxvjkkxb3\r\ntwontnqpcqc17\r\ncxdmgmvmfssevenone6onezdmnltchtnfour\r\ncpcthreeb76zlglhtkdxrlxjsevenzmvd\r\nsixbhjbcpfjeightjcdthzccpzeight1kknxfck\r\nbhkplfzcdqdfsffcone3seven\r\nninethreeqnxmgmjct2\r\nninexjlfivelqznkhngnsvnqhqsqdglsix78\r\n9zbqrkmvvnine\r\n1ninehqtmlsd6zjmbgbhjm8\r\nfourvmht91nine551\r\n8eightmfgjteight4one\r\n6eight1lhfhmqvjsixjpdgnjrzzbtbcgb\r\nlxptvkmftqffksixtpfnvkxzvkldfpeightnhncz6\r\nlnsvgtjs2nbsqbkjs\r\n8twohtdv32\r\n9cbdbvvmninekzbrfchsseven1\r\n8onethree7\r\nhk7fourxvqdqmnsdnine\r\nhxbjdsk1vkjbsqn6six3nine7four\r\n485\r\n5four1kmbcxhjseven\r\n2hjfhtmfg3sixonetwo3five\r\ndvfk7sixninethree\r\nonesix827\r\n87seventhree\r\ntwosix16lfdfkxbmbcfive\r\n1mssxhvgvmxfoursbjdnbrts27rllfm17\r\nrrvpckn9fourgvrhhzppncrqqml7keightwop\r\nknvmsveightxpbmxptkjbtmzzn3pzbl\r\n47eight1\r\n815vd5gnbgone\r\nxbclfszchvone21\r\n7ttwofourthreehjhpjmtwogrng4\r\ntwothreeoneseven9qd66\r\n9dhbgmqgr7threekfhzkqqg\r\nfivekvxpqrkkffc6mjrpksfcqfln9\r\n63two97\r\ntxbn163qkbddlcgdznine9\r\ndztphkcfnnninekjqdb89one\r\nmqvtrtz9\r\n7hcnmcs\r\nfoursix7nine\r\nsevenstm9gfjvjcnmjnnhbgmrkgkccsflm\r\ntwo2jgfqdmlkdndmsp1rqlrqonel\r\neight2qfive1oneqjnine\r\nmtnxzx7tthreeshdxpcrhrk\r\nvzdgktfcq1xtfxqzzfdpng693btkcqhxpsmczbxq\r\nzbvgtnzmlghvhnklhmhjnxckone4six\r\n98eight2seven3hhbxgvnhbg\r\nseventwo7seventhree5ltlptmhjp\r\n1rf75fivegx\r\n2nineonemlhxmhdt7six3\r\nnine6sevenlzndhbnpkxdhdtcqpzgvkskvjkhphpqnxl\r\nqnqpnlxcjr3phkkpnccxr2sixrslhrtf2\r\n12mrkvqsjdcc47six\r\nonehhdveight35jgnmgvqgxdr\r\nhgoneight5\r\nm9eight384eight1\r\n1p6\r\n3sixnine41seventhree4\r\n5dvssdf\r\nblchhcfourgzvssbhqdxdbxt14zvbknhnll7\r\n7twotgqrxddm5\r\nbtlkbgbtwotwo5\r\nfive63ninesnqx\r\nfivemkvjpslfoursixfivepjvtx4\r\n74threeeighteight6cpbxbqgzh\r\ntwoeight7bh\r\nrgtwo7fnck7\r\nfive4sixnvjtcmx12one\r\nghqgdfour33\r\ntjpdztkfour666dxgzjzlgnz\r\nninegnqrqpbrz8seven7sevenhfbone\r\nnpzlpklnvgone6nrjcpz8\r\n2seven6m8\r\nseven3fivegqvxgrjcnine2xppl\r\nnbmvdgk9grz4\r\nfour291\r\ntdnfgkzkxbfpkpcthreenineoneone1\r\n7nineflqptxmdjgttpll\r\none1jnhcvthree1\r\nfoureightkxfcqlkp2fclpr8bzxtfbl8grdsntkrst\r\nsix16fivezqbchmjbb\r\nzjhkd5two8\r\n745shv\r\nl64dqvsixthreethree\r\nrffrrmjsfj2jblgqnl7gjfcqtszfour7\r\nfcqcmchhc7t\r\ntwofour834ninefpvbvps\r\ngmhhjr94svpddnmxvd98threerlljccvq\r\nninetwosevenb71three\r\neight4xllkpmjkrp4bv\r\nzhvzsfourrkflmjpjhfourfjbd32jkvrpzqg\r\n2frgbkngmsix9stldncmsczh\r\neight9three42grlbfps85\r\n1lrshxpgxlsnrlfjlxk2\r\njfhmhcml8mvbfkxhmoneeight9\r\nfive8sevenlzvpzpsbjfourseven1fkcfdf\r\n4vmldcjpbbsnfourseven4three\r\nmfchhbqk7bdlrqhone2fiveone\r\nhnncfrgmnkg5six\r\ndbone55seven\r\ngeightwoonevhxbqbpfkx6two67\r\nsixcrnq1hnrsttfxvjeighteighttwoone\r\nfiveonetwo7six\r\n9nqrmt5n9fkpbhd7\r\ntwo1fivesixtsrq\r\n684\r\nckbxntxfhthreefour7sixseventwo\r\nstdhzqdpnxnine6tn7kjxftfbksevennhfxznjxgchm\r\n8czxhfptlknjlhn5clhzdfgntx741\r\n3nine64vvgsfour61pzb\r\nrloneight7lfrfqqb8fivefour3\r\nvnhbtkbqone4sixsevennmrgmmptvreight4\r\nbdvjp354992jgfhzzvhv\r\nfourp1\r\nfive7oneseven\r\noneone954threefivesixsfr\r\nsixfivevmzlzdfjvq5\r\n4bs\r\nthreetwo64ccks3\r\nonetxqh3ljpnkr9onegsmkq\r\nfive24seven6threethreezfqzgzjztgntkcfzt\r\n3fourv2\r\neightoneeight6qseven47seven\r\n559ninexcdkqvszsq1\r\n95sixthreetwo8fourthreesix\r\nksxtrn1gqxthvxjltfivejpmgvz8\r\nninezdkfvgceightnine7sevenfiveeight1\r\nh43zktkckcjrg5nmzjkrzmjqsix3\r\n44pqlgmmzvgzpslmnccdjlvq\r\n4threefoursix87\r\n92gnjfsxzlcn71qzcbvq6nhmgsvmbrvvjzqlndhl\r\nhkmjkc9fourpbgjlvqxhbhnzvmlnfrqsixsixksix\r\nmspbpsgzn31ninesix\r\n7xqtttthreegr4fourrbflxfznfs5three\r\nrtpknqgsix7sixthreethree1one\r\nqqlqh8seven\r\nsix11eightkh73one\r\neight9mjzpmhcr999fourfive\r\nfzeightwo7smqq\r\n7dzzxnttq\r\n4vfk9\r\nninermjmpprxmsdgrpgzmmqtjxkpfour5kscxs\r\nh5lnhnrqhvltpsns\r\ntwosfdsxcjjhg871755\r\n1one5\r\n933zdzz1five2\r\n4zxh9j\r\nbnlmdd9\r\nnine4xchhpgnfjtwohggvlkkxthznnf7four\r\n3foursixhmsddvmqkgpjvone34\r\nbjfxjlseventhreeninesevenfivethree9\r\nqhqgxtjvslnvbvjsixjplmfq8\r\n8ffjpthreerzkdjkjjzxvqkspsevenfive\r\n3three4two1\r\nfiveldkk7ninesevenmfnjfjmdgeightprjrq\r\n4rqbz6eight3lbgbpgcveightthreefive\r\nsixdsmvltdv2six3fourxtkzsvjdbvqfmthree\r\n3one2xgzvczlxvfdpjqgninefourfourzft\r\nsixcnfznvcb8four\r\n3threethree\r\ntrzqdpslthree8\r\n3fivefourninefivethreefive8nine\r\n1sevensevennineninezmghprscjskqppgmh\r\n6zfoneqkxhxmtwofour3four9\r\ntwosix6dxftmjgclkkmzxmkglmqvsrtjcp\r\nninejkbk8v5fivefivethree\r\n9twoneqv\r\n1cq51lklfoureight2\r\n8sixfournine3one\r\n5plgtszkt6856six\r\nqoneqjph11hgvhhkglsreight1pkxrltrzm\r\nnine25mlxmkmcg4xlrntfsrrxmlhdtzt1\r\nfivetfdzmsq2\r\npdhnkbjrj5fiverjpgmntqkpmx\r\nfourvgc1msdnxrbpbcjfive\r\n14tbcfmjl3sevenvj\r\nninezrcfqvg9\r\n5eighteightkkvtsbrkjlthreegspdm\r\n99four5two9\r\npvlvjvhmg5krzl149sixtknbgfsgvf\r\n44tvzgpz1\r\n8threenmhmptmshpcsix\r\n5rdjmjnmkcd\r\nctwo6\r\ntwo1dhtmsdtsds\r\nndjd4sbzm5fourseven82\r\nrfqsxkdhcr1twotwo\r\n4qrt5threetwosevenffjdvtzhgfd\r\n6421\r\nsjgfshzjg5four\r\nthreeqpvpvdhgjhpgqxsrhhp5dqjqlr\r\nfive7ncchvpcfmglmfzstrmvhfnqndzrmvb5\r\nfvnfmcrh684bjq63dxnnlznrn\r\nthreedccxvrtbj62bfqfzlpxms8five\r\n893shxkgpvpfour36nine7\r\ndtoneightbrmthree6\r\n6seven58nine1mgqqtzfsszlrgghmlknx\r\nfour64\r\nfive5dklfour4\r\nlgv2eightvcp\r\npnfkrfnncv3lgqlrznone\r\nsgcthreegxrnfkpb731\r\n8twothreetnxlmjtwoneb\r\ntxkrmcklpdhclrklxz41lhddmkp\r\nrqndtwosixq8\r\nbtbndntqsllxc6vzfrdqm2sixfiveeight\r\nrhvfourp1seven5cxcc\r\njlzzqkvfxqltgbnj1\r\n24szksixthreeone62\r\n2fourfpmjltjnqvgrgxxbggtseven6qms\r\n78prqkfbf6sevenfivesixeight\r\ndrtwoszsevenckqrxfseven3sixseven\r\nzbsj6four\r\nhrcxgvdbd6\r\nsix9three4onefournnsxgvjtrdthree\r\n441\r\nfjnjksnvgjznxflonetwovcnmvhdgjfggfvxmmg2hppfcgjqv2\r\nkjszbvrcqznbf4eight5four\r\ntwolmbrdmx8kpltmqznslfsixsix\r\n6bjrfthk8\r\ngmzzsthreensrx3\r\nsevenz63xlscxeight\r\nfivehmrcphp7nine53\r\nfivepmqvjqllgthree5vkpn94nine\r\nseventhree9sbklvfvpsixr6\r\none56six\r\npfivetmqrbqxccpxsbcc87five8\r\nmtmnvlhfsix75ppk9rrqzbbplmbseven\r\n547mmntlxflkztkkftxkrrk\r\n5four9threelcqlsrlvg2\r\ngglpjhvjnnnrcbj3n55\r\nxgdbjcrxdf5jjdfrrkzkdzpjkrlstwogbzcjq\r\ncfmgxkjcfq9bkcpkrpltp\r\nfcqkjhqgpkthree4sixthree84frmfqqkrs\r\nonetwosveight68ftgjft3four\r\njvlmg2eight3bdptwo4sixseven\r\nthree1bhdkfnvt\r\n6eight12fiveseven\r\nonedbxgcqnltfour35\r\nsxtwone5336psninexnrjsxsix\r\nfour79one47jvmmhhggcthreecgkxhnlm\r\n17eight2fivetzcfmrlxvd\r\nrxlhkjlm778oneone\r\n8one1one499nine\r\nsix2fqd\r\n9smpkfchhzn8seventrpbvcssscseven\r\nnbmqctcldmnvnbnzns9twofive2three\r\n1five1two\r\n89brvbgnine\r\nvcbrztfjzn4\r\n4fvmlvxjd\r\nlsixoneplt7two9\r\nkphbsssvsnjgjnvqjcbh2nkmfeightseven\r\nthree4xsrmfldqgpqxbpsevenfour\r\nrzd8xzmcdch\r\nbjffone41xzone\r\nxkmhqhgr2lxpv4jnsrnfour\r\n31cplcztdkhsix\r\n6tkzzqqckvdlkxrfourrveightwoch\r\n26vkvbdvggfcsjccrkzbh\r\n3nr\r\nninefourklmqgsix3cvnr\r\nmlnzksvhnvvbxpsfnspl6hpqkdmg\r\nbtwone1jpgjdmgbfive\r\n817sixqtvhxpfglj5kzmbtwofive\r\n1tworcsevennine\r\nxseven69six11\r\nfour3sevenjmgqzf3two\r\nmbrfzsj2\r\n8xgsdninefourseven\r\nsix14snscgfnconeeight4\r\nseven4fivefoureightfive1\r\nthreegjgdnqvhqlbdv24fivexdvpdthree\r\n9ldkmtzghbtwohqzzntwofive\r\nfourxh8\r\neightfkxhflcone3xscqdqqkrk\r\nqzlbtgc2sevens7\r\nrfjgmfbjt185hztszz111\r\npxsixssnfgtfour9\r\nzxflhgjnmbgfdqtzs4twojzxbrsix\r\n7cc153fivel8\r\nbzoneightlrvmnrh98\r\nthreetwogd6bhdkrjhxt2three\r\nhlrscbd8rvppfclqdtseven\r\ntwofivelbjh3gbnbdbpthtgpqjmxjlmzjq9zqll\r\n2fczpbhqjqfgzvzzkqgmsevenone58three\r\nfourzvmlt3sggpjzssljc8twoeighttwo\r\nninescglkgftppbm187\r\nfive1vll26two\r\nczghbj5827\r\nnine7threerngqxk\r\nfour5bjbhfglffourseveneightfourj8\r\ndjqrxfive4five8\r\n3xzhpqc6six\r\n1htdxrgtrhvpgz\r\n5bkxxsccdftjmhkfjqvjzjnine\r\npxpdfdnnpqzspxd9xrpvrxhnsix9four3\r\ngtxlzxdninexxhseven5\r\nxcdkvdg7nineeightsdjvkhzgmone\r\nzrnrrpxdfcnine2qgjxzfxcqgghbdk9\r\ntwozrckqbppsixhh7pmrmnktnrb7five\r\ntdxpjz2kccgqzcslm8sixsixtwo\r\n8tgcb32\r\neight391gxm99five8\r\none3fivegrpjr4trqxj5eighteight\r\n7eightzsnndnine8fourgphhbhxn\r\n7five8seven6mhkksix\r\n8jvccfldpqfourgltcqbkpkfourtwohbvnnine2\r\nrrvmvtvbrmsgnstbghfl28\r\n66fourninekjzfzrj\r\nseventwoninethree3plvfoureight5\r\nfmpzrfpqqbfivenine7\r\nnrkbbdqdthree1fkbfivefourqlksbfdsjtthplhjhlvgh\r\n176seven\r\n3fourfiveseven681\r\nfive88rzxk3mqgtkvgpdx\r\npgttnnvnhtl4rljpqjzhphmkztwokdqspbth\r\n54eightgngggmdmnxgd\r\nd6jnkq78cgvkrgseven\r\nsixeight7eight1dmvvprm\r\n72twotwo2kntsrccqkmzbn4\r\nsnctbphhl2jgpghbvhg\r\none5xxvhfive6twozmlxddppmb\r\n145eight5jcpmqhkpgrdbvlzl3\r\ntwo4vtlfddtzrzlmkgx15\r\n2fourseven9pxqzdf3\r\n6ninec3\r\nninefsix54\r\nsevenbzgrdbbvfmbkvb8\r\nvntfxdprf91rmgvxlxhntsztmggjr1\r\nsix4spdffrjfthree595four\r\npxfftjkdnninexkjvskrtpmjkhnncflz26\r\ndkjmxmhpc7eight7\r\nhsbdfeight9hhrjcn8twothreehjpnbhslcc\r\n437kzcqvsmxkknfour\r\n8twoone54sixvmlcjdnrgnqbmlrvdtnh\r\none587\r\n4kxxsrcseven33dcvbbgkbcd4fourfour\r\nnine56\r\noneeightpz4rqbrcdvjbx55\r\nthreefive33ninexrlj\r\n3bxjdxlmlgs\r\ngqmkpqpppfour9fouroneeightseven\r\n492\r\none398threetwo6dseven\r\nj8vlfrninebdgnineljtvbeight\r\nnnnhx28sixtwo\r\nfiverbgztggr6ktrsfvbtqlbtdshqjxjhj\r\nqmdjfthzfour318hrffjj\r\n977dpssrfgfxfxkk6\r\nrvklzfdfour3twofour8five\r\nczbjbfdcbs1rgkfscgntmhksixhqgbrmzvzrg\r\n3xqlbqbcxnfq\r\nsix29\r\njhnfthree7\r\nfive1821\r\n578blhpbtrjthree83qtflsj\r\nfgzqnrvfcqkfrdmgkndmrxfctgvsbfive2eight5\r\nfeight8eight\r\n3qmfbdztrgpb5\r\nck5three14lzmffcljxcr\r\n3twoqgjqlvjeight5nddhpflj1\r\nvvdsttjjjgnrzgfournkkhp622onesix\r\ntwo7seven6\r\n7941\r\n28two7\r\nninejhxnjctz3jtxmlmjg\r\nvmjpxvqg24pzjfsxvcg5seven2\r\nxpqbffpvmn5\r\n32eightseventhreekqdgtcxgjxvv1seven\r\n2eight3tllbkklghb7\r\nsevenfour1\r\ntjsjfldclvqq1sxcl\r\nmrdqvsxk15jbxstdph\r\n9fivefivebbtcvhqjjdvvqeight\r\nfourdtbkzvhrbvzqnnzghnpv1231\r\nbz34five1\r\nsix26two2\r\nbczkffnrtmsrctwoninelbnxoneeight2\r\nsevenstvffmtkqqxg57hthreeeight\r\n4fivesevenrdfcdrxd4\r\nbbbrjsjrmn8px\r\n317vncvpdrh91threetwosix\r\n9sevenzpfivethreefivenineseven7\r\ntwodsnvkbvfbtwo62tt6\r\nthreesctkeight3vdjrnflh9nckgmzhdf4\r\neightsixtwo39skhnzf\r\nfoursix6\r\n3sixzp5fdzjv\r\nntwone9xzspfhrthreehsgpqdone62\r\nfive9597tgrfbl9\r\nsix4rvrcbbjzfdcgctsxjxmjrpc4thmmj8\r\n3sixmdglgdj2zzrkgsdgk2\r\ncbfxpgftninekthreexvmhxmkx1fourf\r\n76twoone\r\n7six32two1fivefspjtdsix\r\nnrcntbgdtjsevenztsmsgfmfour9thslsmhgnk2three\r\n21ltslbrnineseven7\r\n41\r\nsevencdsnmzkspseven49\r\njbzkthreebjgvhfhcftwojbzdbmcdlff29\r\nsevengjlph11fivexhzdrs\r\nfzkznzxgbsfq4\r\ngvpqjgrfdbdtrpqseven11mmjpkz5\r\nksfjpnchqzqone15eightsixfivenine\r\n2skjmpvdfoursixtwones\r\ndmtzhqfivethree3eighteightoneseven\r\none6fourrrrtkkjvr\r\n229spkrxlg\r\n4xjqzfourdtmq\r\nmkv5six\r\n8jdzlpqvc89two\r\n2foursix69k\r\nxbqrmktzfive4\r\nfive9rjrvcpfbseightfkmlgbvqkbqj\r\nqnmkvkmckfxqmdtwosevendj6sevensixfive\r\nmkdvknghvsgzrbbjqngbsqeight6mjxfivenineq\r\n6two97mxm\r\ntwo26jjqjs\r\n1scslcns\r\npckdk4onesevenpnxq8lxxbzvftcbeightl\r\nqczvprdbeight3twosixsevenfivenbzj\r\n462mfgmhfseven4vmv\r\ngqsrhltninethreedbkrjdfivetwo1\r\nppsix99nine8qvhbnn48\r\nnine35fxlxqfctwonezf\r\nfour2twofive1\r\n847dsgonethree1vkmhmtv\r\n8gnfbqmzszxdfkv5five\r\n22kvqd\r\nfive1sevenl59\r\nkgshxdjdfjqzthhplhjqxbjpbxggtz1\r\nfourbzbzvtfj8twoone6629\r\nhn28six1\r\nxqxknfivevxhljqpsixtwo3\r\nhsconethree1fourthree\r\nthree5gnlgcthree36rkvlpkcvronefour\r\nrvjqkndonenine3hbrtlzhcbfbkcfive\r\nhhrmnbnct6rdxxtkxkcrbdfg5\r\n6xsqkbthreerjgbzfhb\r\nsixnlxzmblfzx5cspjqthree\r\n4twondrxjb\r\n4three6b\r\n4four3three16\r\neight3hshdzptsq6twosfour3\r\neight37twotrxvpxk2ksbldctj\r\nfourseven8fkmtqzdbfourseven\r\n6vngvcmplx\r\njhr6gfplmzpr2fourfive\r\neightnine49twoeight2nfndmmb\r\nthree7threej4xnffjtnckltwo\r\nonegzlnjsgzlg82mkbfhtmhfour\r\n85vnseight5fivevcqrgvgrtp\r\n47chxx6pkrdxvmrvvfxbl5\r\n34ctkstrjxsnfourseven\r\ntwo9zcrghthreethree\r\nveight37\r\ntwo44nine449\r\n58eight98cspxfhftvx\r\ncxpththree7pbmhhmkfzfvthree\r\n8nine2hbmdnvbthree\r\n1four6ncdvzqjqhx1\r\n1bgqspl958lrj\r\n7nvmqrnthreejbzgnzvzpgkr69\r\n7576threesix\r\ntwoc83pt\r\nfourkdnsvcq9sevendmhsdgt54threej\r\nzrjts8sixsix237flm\r\n8eightrndfour\r\ntwo9jsix5gcxf\r\nfivefour7nineseven1qtcdqbp1four\r\nfourzvkqhdninetwoftscrmsd64nxsgx\r\nq1tdsskthree\r\nmkhttggvjh9ctzffdqdjnheightninegmxqxhqrfqgbgzt\r\nninep2fourf\r\nfiveeight2zxjpzffvdsevenjhjvjfiveone\r\n15737seven\r\npdrss6oneone4fournine\r\n7b\r\n";
            //string input = "two1nine\r\neightwothree\r\nabcone2threexyz\r\nxtwone3four\r\n4nineeightseven2\r\nzoneight234\r\n7pqrstsixteen";
            string inputFixed = FixString(input);
            string[] lineArr = SplitLines(inputFixed);

            Console.WriteLine(SumOfAllLines(lineArr));
            Console.WriteLine(SumOfAllLinesText(lineArr));
        }

        public static string FixString(string input)
        {
            return Regex.Replace(input, "\r", "");
        }

        public static string[] SplitLines(string input)
        {
            //Splits text into new lines and removes emtpy entries
            string[] lines = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            return lines;
        }

        public static void PrintStringArr(string[] lines)
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public static int SumOfAllLines(string[] lines)
        {
            int sum = 0;

            foreach (string line in lines)
            {

                char[] numberArr = new char[2];
                numberArr[0] = ReturnFirstNumberOfLine(line);
                numberArr[1] = ReturnLastNumberOfLine(line);

                string numberString = new string(numberArr);


                sum += Int32.Parse(numberString);

            }


            return sum;
        }

        public static char[] charsToMatch = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };


        public static char ReturnFirstNumberOfLine(string line)
        {
            char first;
            for (int i = 0; i < line.Length; i++)
            {
                for (int j = 0; j < charsToMatch.Length; j++)
                {
                    if (line[i] == charsToMatch[j])
                    {
                        first = charsToMatch[j];
                        return first;
                    }
                }
            }

            return '0';
        }

        public static char ReturnLastNumberOfLine(string line)
        {
            char last;
            for (int i = line.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < charsToMatch.Length; j++)
                {
                    if (line[i] == charsToMatch[j])
                    {
                        last = charsToMatch[j];
                        return last;
                    }
                }
            }

            return '0';
        }

        public static int SumOfAllLinesText(string[] lines)
        {
            int sum = 0;

            foreach (string line in lines)
            {
                    char[] numberArr = new char[2];
                    numberArr[0] = ReturnFirstNumberOfLineText(line);
                    numberArr[1] = ReturnLastNumberOfLineText(line);

                    string numberString = new string(numberArr);


                    sum += Int32.Parse(numberString);

            }


            return sum;
        }



        public static char ReturnFirstNumberOfLineText(string line)
        {


            MatchCollection collectionOfNumber = Regex.Matches(line, "[0-9]|one|two|three|four|five|six|seven|eight|nine");

            char number = new();

            string numberString = collectionOfNumber[0].ToString();

            switch (numberString)
            {
                case "0":
                    number = '0';
                    break;
                case "1":
                case "one":
                    number = '1';
                    break;
                case "2":
                case "two":
                    number = '2';
                    break;
                case "3":
                case "three":
                    number = '3';
                    break;
                case "4":
                case "four":
                    number = '4';
                    break;
                case "5":
                case "five":
                    number = '5';
                    break;
                case "6":
                case "six":
                    number = '6';
                    break;
                case "7":
                case "seven":
                    number = '7';
                    break;
                case "8":
                case "eight":
                    number = '8';
                    break;
                case "9":
                case "nine":
                    number = '9';
                    break;
            }
            return number;

        }


        public static char ReturnLastNumberOfLineText(string line)
        {
            //use regexoption right to left match to avoid that overlapping expressions don't match
            MatchCollection collectionOfNumber = Regex.Matches(line, "[0-9]|one|two|three|four|five|six|seven|eight|nine", RegexOptions.RightToLeft);

            char number = new();

            string numberString = collectionOfNumber[0].ToString();

            switch (numberString)
            {
                case "0":
                    number = '0';
                    break;
                case "1":
                case "one":
                    number = '1';
                    break;
                case "2":
                case "two":
                    number = '2';
                    break;
                case "3":
                case "three":
                    number = '3';
                    break;
                case "4":
                case "four":
                    number = '4';
                    break;
                case "5":
                case "five":
                    number = '5';
                    break;
                case "6":
                case "six":
                    number = '6';
                    break;
                case "7":
                case "seven":
                    number = '7';
                    break;
                case "8":
                case "eight":
                    number = '8';
                    break;
                case "9":
                case "nine":
                    number = '9';
                    break;
            }

            return number;
        }

    }
}
