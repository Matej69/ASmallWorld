using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemMessagesInfo {

    static private ItemMessagesInfo instance;
	static public ItemMessagesInfo Instance()
    {
        return (instance == null) ? instance = new ItemMessagesInfo() : instance; 
    }



    public List<TextboxMessageInfo> GetMessages(SpriteManager.E_SPRITE _id)
    {
        List<TextboxMessageInfo> txtInfoList = new List<TextboxMessageInfo>();

        switch (_id)
        {
            case SpriteManager.E_SPRITE.ARROW:
                txtInfoList.Add(new TextboxMessageInfo("This guy has just thrown an arrow in my 'small world'"));
                txtInfoList.Add(new TextboxMessageInfo("I-m not sure what this guy is up to but I-m starting to get scared."));
                txtInfoList.Add(new TextboxMessageInfo("Still better then Arrow on CW tho /./"));
                break;
            case SpriteManager.E_SPRITE.BANANA:
                txtInfoList.Add(new TextboxMessageInfo("Banana is in the hole!"));
                txtInfoList.Add(new TextboxMessageInfo("I'm not monkey you idiot feed me with fish food!!"));
                break;
            case SpriteManager.E_SPRITE.BEER:
                txtInfoList.Add(new TextboxMessageInfo("Let me take a sip of this beverage..."));
                txtInfoList.Add(new TextboxMessageInfo("WOOOOW.... EVERITHING IS....... MOVING...... shiaaaaaaaaattttt :P :P: P"));
                break;
            case SpriteManager.E_SPRITE.BILLIAR_BALL:
                txtInfoList.Add(new TextboxMessageInfo("Usually I would be pissed but after all crap we have been through....."));
                txtInfoList.Add(new TextboxMessageInfo(" 8 is my favourite number so whatever....."));
                txtInfoList.Add(new TextboxMessageInfo("............"));
                txtInfoList.Add(new TextboxMessageInfo("......................"));
                txtInfoList.Add(new TextboxMessageInfo("................................"));
                txtInfoList.Add(new TextboxMessageInfo("after 69 ofcourse ........ :)"));
                break;
            case SpriteManager.E_SPRITE.BOOK:
                txtInfoList.Add(new TextboxMessageInfo("Oh look a book that's not that bad sinc........"));
                txtInfoList.Add(new TextboxMessageInfo("GOD DAMMMMMMMNNNN!!!"));
                txtInfoList.Add(new TextboxMessageInfo("WHYY.... WHYY HARRY POTTER BOOK.... OUT OF ALL THAT YOU COULD THROWN... y-u-o bastard."));
                break;
            case SpriteManager.E_SPRITE.BRICK:
                txtInfoList.Add(new TextboxMessageInfo("ARE YOU INSANE?"));
                txtInfoList.Add(new TextboxMessageInfo("WAIT... YOU HAVE TAKEN BRICK FROM YOUR WALL JUST SO YOU CAN TORTURE ME??!?!"));
                txtInfoList.Add(new TextboxMessageInfo("Not sure if I should be scared for my life or flattered..."));
                break;
            case SpriteManager.E_SPRITE.CHAIN:
                txtInfoList.Add(new TextboxMessageInfo("NOW WE'RE TALKING!"));
                txtInfoList.Add(new TextboxMessageInfo("(RAP)FISH IN A GOLD CHAIN, NO REMORSE NO PAIN, SHIZLE MINE RIZZLE UUOAOOOO!"));
                txtInfoList.Add(new TextboxMessageInfo("Don't judge me dude..."));
                break;
            case SpriteManager.E_SPRITE.COFFEE:
                txtInfoList.Add(new TextboxMessageInfo("Hmmmmm I have never tried coffee before."));
                txtInfoList.Add(new TextboxMessageInfo("Let me take a sip of that drink..."));
                txtInfoList.Add(new TextboxMessageInfo("Not bad for a......DASJAS OIFHJ IO I'MMMM A SWIMMMMMING LIKE CRAZY :)::)::):):): xdxdxd XD LOL HOHOHOHOHOHOHO"));
                txtInfoList.Add(new TextboxMessageInfo("COFFFFEEEEEEEEEEEEEE OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOLAAAAAAAAAAAAAAAAAAAAAAAA"));
                break;
            case SpriteManager.E_SPRITE.COOKIE:
                txtInfoList.Add(new TextboxMessageInfo("What am I suppose to do with that."));
                txtInfoList.Add(new TextboxMessageInfo("Not bad taste."));
                txtInfoList.Add(new TextboxMessageInfo("Chocolate cookie you said...... MORE! MOOOREEEEE!"));
                break;
            case SpriteManager.E_SPRITE.DIAMOND:
                txtInfoList.Add(new TextboxMessageInfo("What is this shiny entity I'm seeing?"));
                txtInfoList.Add(new TextboxMessageInfo("Not eatable nor usable for survival...."));
                txtInfoList.Add(new TextboxMessageInfo("Humans are sometimes such strange creatures."));
                break;
            case SpriteManager.E_SPRITE.EYE_BALL:
                txtInfoList.Add(new TextboxMessageInfo("Hey what is...OHH MY GOD!!"));
                txtInfoList.Add(new TextboxMessageInfo("DUDE ARE YOU OK.... THIS IS TO MUCH...YOUR OWN EYE?!?!!"));
                txtInfoList.Add(new TextboxMessageInfo("I guess I will be...."));
                txtInfoList.Add(new TextboxMessageInfo("seeing you later..."));
                txtInfoList.Add(new TextboxMessageInfo("............"));
                txtInfoList.Add(new TextboxMessageInfo(" ;) "));
                break;
            case SpriteManager.E_SPRITE.FEMALE_FISH:
                txtInfoList.Add(new TextboxMessageInfo("Ohhh mama miaaaa."));
                txtInfoList.Add(new TextboxMessageInfo("Well I can't say I'm glad that I'm not alone anymore but.."));
                txtInfoList.Add(new TextboxMessageInfo("She is French soo....."));
                txtInfoList.Add(new TextboxMessageInfo(" =) "));
                break;
            case SpriteManager.E_SPRITE.FISH_FOOD:
                txtInfoList.Add(new TextboxMessageInfo("Day 6"));
                txtInfoList.Add(new TextboxMessageInfo("Idiot finally decided to feed me."));
                txtInfoList.Add(new TextboxMessageInfo("Nope nope nope.... never mind this is dog food."));
                break;
            case SpriteManager.E_SPRITE.FISH_SKULL:
                txtInfoList.Add(new TextboxMessageInfo("What is... OH MY LORD MOVE THAT THING AWAY!!!"));
                txtInfoList.Add(new TextboxMessageInfo("ARE YOU CRAZY??"));
                txtInfoList.Add(new TextboxMessageInfo("MOVE THIS CORPSE AWAY AND GIVE IT A PROPER BURIAL!"));
                break;
            case SpriteManager.E_SPRITE.GLASSES:
                txtInfoList.Add(new TextboxMessageInfo("Finally some SWAG in this biaaacccccc."));
                txtInfoList.Add(new TextboxMessageInfo("Not bad human, not bad."));
                break;
            case SpriteManager.E_SPRITE.HAT:
                txtInfoList.Add(new TextboxMessageInfo("Ohhhhhhh shiiiaaaaaaaatttt...."));
                txtInfoList.Add(new TextboxMessageInfo("I'll take it"));
                txtInfoList.Add(new TextboxMessageInfo("but event that won't be able to hide the shame on my face that you are my owner"));
                break;
            case SpriteManager.E_SPRITE.KNIFE:
                txtInfoList.Add(new TextboxMessageInfo("WHAT ARE YOU DOING WITH..... AAAAAAAAAA HOOOOH AAAAAAAAADDDDD!!!!!"));
                txtInfoList.Add(new TextboxMessageInfo("ARE YOU FUC**** STUPID!?!?!?"));
                txtInfoList.Add(new TextboxMessageInfo("LOOK AT ME......I'M NOT EVEN A HALF OF A FISH NOW"));
                txtInfoList.Add(new TextboxMessageInfo("Then again this is exactly how I feel from inside so who gives a damn"));
                break;
            case SpriteManager.E_SPRITE.MEAT:
                txtInfoList.Add(new TextboxMessageInfo("You don't have money for rent but are throwing chicken to your fish??"));
                txtInfoList.Add(new TextboxMessageInfo("I also don't eat meat."));
                txtInfoList.Add(new TextboxMessageInfo("But sometimes...... I wish I was chicken so I can end up in KFC"));
                txtInfoList.Add(new TextboxMessageInfo("Cool place..."));
                break;
            case SpriteManager.E_SPRITE.MILK:
                txtInfoList.Add(new TextboxMessageInfo("I have just cleaned my small world and you threw a fuc** MILK!!!?"));
                txtInfoList.Add(new TextboxMessageInfo("Aaaaaaaaand I don't see anything anymore...."));
                txtInfoList.Add(new TextboxMessageInfo("maybe it is better that way..... ate least I can't see how big of a loser you've become"));
                break;
            case SpriteManager.E_SPRITE.MONEY:
                txtInfoList.Add(new TextboxMessageInfo("I have no use for this but you could have spent that to pay your RENT YOU IDIOT!!!!"));
                break;
            case SpriteManager.E_SPRITE.MUSHROOM:
                txtInfoList.Add(new TextboxMessageInfo("WHAT IS.................. O-O o_O O--o O=0 o-O 8) (8 "));
                txtInfoList.Add(new TextboxMessageInfo("Oo O=0 -O o_O O--o O=0 o-O 8)o O=0  (8o O=0  ★☆ ★☆ ★☆ ★☆ ★☆ ★☆ "));
                txtInfoList.Add(new TextboxMessageInfo("☀☁☂☃★☆ ۞  ≈๑۩★☆ ..۩۩★☆  ✲★☆ ۩ ۩.. ..★☆ ۩۞★☆ ★☆  ~"));
                txtInfoList.Add(new TextboxMessageInfo("AGAIN!!!! THROW SHROOM AGAIN!!!!"));
                break;
            case SpriteManager.E_SPRITE.OTTO:
                txtInfoList.Add(new TextboxMessageInfo("Is that... OMG IT IS OTTO!?!?"));
                txtInfoList.Add(new TextboxMessageInfo("PLS.... PLEASE..... REMOVE THIS MONSTER FROM MY AQUARIUM...."));
                txtInfoList.Add(new TextboxMessageInfo("HE'S FOLLOWING ME MAN............... :( :( "));
                break;
            case SpriteManager.E_SPRITE.PAPER:
                txtInfoList.Add(new TextboxMessageInfo("AHHH SHI*** MY EYES!!"));
                txtInfoList.Add(new TextboxMessageInfo("LOOK AT THEM!!!! LOOK WHAT YOU'VE DONE"));
                txtInfoList.Add(new TextboxMessageInfo("IT BURNSSSSS!!!!!!"));
                break;
            case SpriteManager.E_SPRITE.POOP:
                txtInfoList.Add(new TextboxMessageInfo("YOU... WOULDN'T DARE......."));
                txtInfoList.Add(new TextboxMessageInfo("IT'S IN MY MOUTH..AAAAAAA IN MY FREAKING MOUTHHHHHHH  :_d;s:_a;d"));
                break;
            case SpriteManager.E_SPRITE.RING:
                txtInfoList.Add(new TextboxMessageInfo("ALL SINGLE LADIES.... ALL SINGLE LADIES....."));
                txtInfoList.Add(new TextboxMessageInfo("PUT A RING ON IT.... NANNA....."));
                txtInfoList.Add(new TextboxMessageInfo("Ohhhh..... how long have you beenstanding there....."));
                txtInfoList.Add(new TextboxMessageInfo("YOU        SAW       NOTHING!"));
                break;
            case SpriteManager.E_SPRITE.RUBBER_DUCK:
                txtInfoList.Add(new TextboxMessageInfo("FUC** DUCK"));
                txtInfoList.Add(new TextboxMessageInfo("D           U            C           K                 MUST            DIE         "));
                break;
            case SpriteManager.E_SPRITE.SALT:
                txtInfoList.Add(new TextboxMessageInfo("Salt....you are throwing salt at me....."));
                txtInfoList.Add(new TextboxMessageInfo("No wonder you're still living with your ex girlfriend"));
                txtInfoList.Add(new TextboxMessageInfo("Did I say something wrong?? :) "));
                break;
            case SpriteManager.E_SPRITE.UNDERPANTS:
                txtInfoList.Add(new TextboxMessageInfo("Wait what.... THAT IS DISGUSTING"));
                txtInfoList.Add(new TextboxMessageInfo("DUDE WHEN DID YOU TAKE A BATH LAST TIME"));
                txtInfoList.Add(new TextboxMessageInfo("Is that chicken from last Cristmas....... KILL MEEE PLSSS!!!!"));
                break;
            default:
                txtInfoList.Add(new TextboxMessageInfo("I HATE MY LIFE"));
                break;
        }

        return txtInfoList;
    }


	
}
