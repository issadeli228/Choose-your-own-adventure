using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Choose_your_own_adventure
{
    public partial class Adventure : Form
    {
        int scene = 0;

        Random randGen = new Random();


        public Adventure()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int value = randGen.Next(1, 7);
            greenOutputLabel.Visible = false;
            pictureBox4.Visible = false;

            SoundPlayer floorCreak = new SoundPlayer(Properties.Resources._326460__miekyj__creaking_floor_owi);
            SoundPlayer evilLaugh = new SoundPlayer(Properties.Resources.Evil_Laugh_Male_6_Himan_1359990674);
            SoundPlayer walkingInGrass = new SoundPlayer(Properties.Resources._155589__leafs67__walking_in_long_grass);
            SoundPlayer keysJingle = new SoundPlayer(Properties.Resources._467060__kelsey_w__key_jingle_2);

            if (e.KeyCode == Keys.M)        //red button
            {
                if (scene == 0) { scene = 1; }

                else if (scene == 1) { scene = 3; }
                else if (scene == 3) { scene = 7; }
                else if (scene == 7) { scene = 16; }
                else if (scene == 16) { scene = 26; }  //fail

                else if (scene == 15) { scene = 24; }
                else if (scene == 24) { scene = 28; }
                else if (scene == 6) { scene = 9; }
                else if (scene == 9) { scene = 17; }  //fail
                else if (scene == 28) { scene = 30; }  //fail

                else if (scene == 2) { scene = 5; }
                else if (scene == 5) { scene = 14; }
                else if (value <= 6 && scene == 14) { scene = 22; } //success
                else if (value >= 7 && scene == 14) { scene = 21; } //fail

                else if (scene == 4) { scene = 12; }
                else if (scene == 12) { scene = 19; }  //fail

                else if (scene == 31) { scene = 0; }
                else if (scene == 32) { scene = 0; }

                else if (scene == 26) { scene = 1; }  //restart
                else if (scene == 17) { scene = 1; }
                else if (scene == 30) { scene = 1; }
                else if (scene == 22) { scene = 1; }
                else if (scene == 21) { scene = 1; }
                else if (scene == 19) { scene = 1; }
                else if (scene == 11) { scene = 1; }
                else if (scene == 13) { scene = 1; }
                else if (scene == 20) { scene = 1; }
                else if (scene == 18) { scene = 1; }
                else if (scene == 23) { scene = 1; }
                else if (scene == 27) { scene = 1; }
                else if (scene == 29) { scene = 1; }
                else if (scene == 25) { scene = 1; }
                else if (scene == 8) { scene = 1; }
            }

            else if (e.KeyCode == Keys.B)     //blue button
            {
                if (scene == 0) { scene = 1; }

                else if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 4) { scene = 11; } //fail
                else if (scene == 2) { scene = 5; }

                else if (scene == 5) { scene = 13; }  //fail
                else if (scene == 14) { scene = 20; }  //fail
                else if (scene == 12) { scene = 18; }  //success
                else if (scene == 2) { scene = 5; }

                else if (scene == 3) { scene = 6; }
                else if (scene == 7) { scene = 15; }
                else if (scene == 15) { scene = 23; }  //fail
                else if (scene == 24) { scene = 27; }  //fail
                else if (scene == 28) { scene = 29; }  //success
                else if (scene == 16) { scene = 25; }  //fail
                else if (scene == 6) { scene = 8; }
                else if (scene == 9) { scene = 14; }

                else if (scene == 26) { scene = 1; }  //restart
                else if (scene == 17) { scene = 1; }
                else if (scene == 30) { scene = 1; }
                else if (scene == 22) { scene = 1; }
                else if (scene == 21) { scene = 1; }
                else if (scene == 19) { scene = 1; }
                else if (scene == 11) { scene = 1; }
                else if (scene == 13) { scene = 1; }
                else if (scene == 20) { scene = 1; }
                else if (scene == 18) { scene = 1; }
                else if (scene == 23) { scene = 1; }
                else if (scene == 27) { scene = 1; }
                else if (scene == 29) { scene = 1; }
                else if (scene == 25) { scene = 1; }
                else if (scene == 8) { scene = 1; }

            }

            else if (e.KeyCode == Keys.Space)   //green button
            {
                if (scene == 6) { scene = 10; }  //fail
            }

            //scenes

            switch (scene)
            {
                case 0:  //start scene  
                    break;
                case 1:
                    outputLabel.Text = "You wake up in an abandoned mansion and have no knowledge about where you are. you have a strange suspition that you're not alone. All you know is that you need to escape. have to options:";
                    redOutputLabel.Text = "go thorugh the door";
                    blueOutputLabel.Text = "jump out the window";
                    evilLaugh.Play();
                    sceneImage.BackgroundImage = Properties.Resources.haunted_mansion;
                    break;
                case 2:
                    outputLabel.Text = "you jumped out the window and landed in a bush. you come up to the front gate.";
                    redOutputLabel.Text = "keep exploring around the house";
                    blueOutputLabel.Text = "try to open the gate";
                    SoundPlayer bush = new SoundPlayer(Properties.Resources._106114__j1987__bushmovement);
                    bush.Play();
                    sceneImage.BackgroundImage = Properties.Resources.front_gate;
                    break;
                case 3:
                    outputLabel.Text = "The door leaves you in the hallway. Do you go left or right?";
                    redOutputLabel.Text = "right";
                    blueOutputLabel.Text = "left";
                    SoundPlayer door = new SoundPlayer(Properties.Resources._431117__inspectorj__door_front_opening_a);
                    door.Play();
                    sceneImage.BackgroundImage = Properties.Resources.hallway;
                    break;
                case 4:
                    outputLabel.Text = "You try opening the gate but it's locked. You hear the floor creaking in the house behind you and know you must be quick.";
                    redOutputLabel.Text = "Run to the back of the house";
                    blueOutputLabel.Text = "Climb over the fence";
                    floorCreak.Play();
                    sceneImage.BackgroundImage = Properties.Resources.locked_gate;
                    break;
                case 5:
                    outputLabel.Text = "you keep going to the side of the house and find a small shed.";
                    redOutputLabel.Text = "try to open the shed";
                    blueOutputLabel.Text = "keep exploring around the house";
                    walkingInGrass.Play();
                    sceneImage.BackgroundImage = Properties.Resources.shed;
                    break;
                case 6:
                    outputLabel.Text = "You come to the kitchen and notice one of the steak knifes is missing. You're deciding what to do next.";
                    redOutputLabel.Text = "Search through the cabinets";
                    blueOutputLabel.Text = "Grab a steak knife for yourself";
                    greenOutputLabel.Visible = true;
                    pictureBox4.Visible = true;
                    greenOutputLabel.Text = "turn on the lights";
                    SoundPlayer bladeSharpen = new SoundPlayer(Properties.Resources._237934__f4ngy__blade_sharpen);
                    bladeSharpen.Play();
                    sceneImage.BackgroundImage = Properties.Resources.haunted_kitchen;
                    break;
                case 7:
                    outputLabel.Text = "You go right. you come to a staircase that goes both up and down.";
                    redOutputLabel.Text = "Go down";
                    blueOutputLabel.Text = "Go up";
                    floorCreak.Play();
                    sceneImage.BackgroundImage = Properties.Resources.haunted_staircase; ;
                    break;
                case 8:
                    outputLabel.Text = "You go over the the knife to grab one, but grabing the knife triggers an alarm triggers, ringing a bell. all of the sudden hes behind you... Play again?";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    greenOutputLabel.Visible = false;
                    pictureBox4.Visible = false;
                    SoundPlayer alarmBell = new SoundPlayer(Properties.Resources._180737__mohomran__alarm_ringing);
                    alarmBell.Play();
                    sceneImage.BackgroundImage = Properties.Resources.bell;
                    break;
                case 9:
                    outputLabel.Text = "You start searching through the cabinets and find a key. you remember look out the window and see a shed a realize this may be the key for that";
                    redOutputLabel.Text = "Keep looking";
                    blueOutputLabel.Text = "Go to the shed";
                    greenOutputLabel.Visible = false;
                    pictureBox4.Visible = false;
                    evilLaugh.Play();
                    sceneImage.BackgroundImage = Properties.Resources.key_on_shelf;
                    break;
                case 10:
                    outputLabel.Text = "you turn on the lights but they start flickering before they burn out. You hear faint foot steps before you turn around and realize you're cornered...";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    greenOutputLabel.Visible = false;
                    pictureBox4.Visible = false;
                    evilLaugh.Play();
                    sceneImage.BackgroundImage = Properties.Resources.dim_bulb;
                    break;
                case 11:
                    outputLabel.Text = "You try to climb over but it was too tall and you fall on your back. You lay there, staring staright up as you notice a creepy figure standing over you... Play again?";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    evilLaugh.Play();
                    sceneImage.BackgroundImage = Properties.Resources.creepy_man;
                    break;
                case 12:
                    outputLabel.Text = "You run around the house. There's a back fence that is cracked open and leads to a forest. You also notice the back door to the house is unlocked";
                    redOutputLabel.Text = "Go back to the house";
                    blueOutputLabel.Text = "Run into the forest";
                    walkingInGrass.Play();
                    sceneImage.BackgroundImage = Properties.Resources.back_fence;
                    break;
                case 13:
                    outputLabel.Text = "You keep going around the house and bump into a creepy figure who had been waiting for you... Play gain?";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    evilLaugh.Play();
                    sceneImage.BackgroundImage = Properties.Resources.creepy_figure;
                    break;
                case 14:
                    outputLabel.Text = "you open the shed a notice a key on the desk. you pick it up and realize it might be the key to the front gate, but you aren't sure. What do you do?";
                    redOutputLabel.Text = "Try it on the front gate";
                    blueOutputLabel.Text = "Keep looking in the shed";
                    keysJingle.Play();
                    sceneImage.BackgroundImage = Properties.Resources.key_on_shelf;
                    break;
                case 15:
                    outputLabel.Text = "you go upstairs. The stairs lead to the attic. you start looking around and find a phone";
                    redOutputLabel.Text = "Keep looking around";
                    blueOutputLabel.Text = "Use the phone to call the police";
                    SoundPlayer walkingUpstairs = new SoundPlayer(Properties.Resources._365904__univ_lyon3__fauvre_lola_2016_2017_steps);
                    walkingUpstairs.Play();
                    sceneImage.BackgroundImage = Properties.Resources.attic;
                    break;
                case 16:
                    outputLabel.Text = "you go down the stairs to the basement. The lights are flickering and you get cold feet.";
                    redOutputLabel.Text = "Explore the basement";
                    blueOutputLabel.Text = "Turn back";
                    SoundPlayer lightsFlicker = new SoundPlayer(Properties.Resources._17556__incarnadine__elements_fire);
                    lightsFlicker.Play();
                    sceneImage.BackgroundImage = Properties.Resources.dim_bulb;
                    break;
                case 17:
                    outputLabel.Text = "You keep looking around the kitchen for anything. As you're looking, you feel someone behind your shoulder... Play again?";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    evilLaugh.Play();
                    sceneImage.BackgroundImage = Properties.Resources.creepy_man;
                    break;
                case 18:
                    outputLabel.Text = "You run into the forest. You run for what feels like forever but make it to the other side and back to civilization. Congratulations!";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    SoundPlayer running = new SoundPlayer(Properties.Resources._430708__juandamb__running);
                    running.Play();
                    sceneImage.BackgroundImage = Properties.Resources.back_fence;
                    break;
                case 19:
                    outputLabel.Text = "You go through the back door and collide with a creepy figure in the doorway. He Seemed to have been waiting for you... Play again?";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    evilLaugh.Play();
                    sceneImage.BackgroundImage = Properties.Resources.creepy_figure;
                    break;
                case 20:
                    outputLabel.Text = "You keep looking around when you feel a tap on your shoulder. Guess you should've gotten out when you got the chance... Play again?";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    evilLaugh.Play();
                    sceneImage.BackgroundImage = Properties.Resources.creepy_knife;
                    break;
                case 21:
                    outputLabel.Text = "You tried to unlock the front gate but it wasn't the right key. you hear footsteps behind you and the sharpening of a blade... Play again?";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    evilLaugh.Play();
                    sceneImage.BackgroundImage = Properties.Resources.creepy_knife;
                    break;
                case 22:
                    outputLabel.Text = "You used the key on the gate and it opens. you run and don't look back. Congratulations!";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    SoundPlayer unlockingDoor = new SoundPlayer(Properties.Resources._208805__buldfot__unlocking_door);
                    unlockingDoor.Play();
                    sceneImage.BackgroundImage = Properties.Resources.open_gate;
                    break;
                case 23:
                    outputLabel.Text = "You use the phone. You hear a horrible screeching noise and release you aren't able to make a call. At the same time, you notice a shadow creeping up behind you... Play again?";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    evilLaugh.Play();
                    sceneImage.BackgroundImage = Properties.Resources.creepy_knife;
                    break;
                case 24:
                    outputLabel.Text = "You keep looking and find car keys. You realize there may be a car in the garage, but you dont know if you've left something improtant in the attic";
                    redOutputLabel.Text = "Go to the garage";
                    blueOutputLabel.Text = "Keep looking";
                    keysJingle.Play();
                    sceneImage.BackgroundImage = Properties.Resources.car_keys;
                    break;
                case 25:
                    outputLabel.Text = "You turn around to head back up the stairs. Unfortunately, someone was waiting at the top for you... Play again?";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    evilLaugh.Play();
                    sceneImage.BackgroundImage = Properties.Resources.top_of_staris;
                    break;
                case 26:
                    outputLabel.Text = "You keep exploring the basement. There doesn't seem to be anything down there until you turn around and realize you're being cornered... Play again? ";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    evilLaugh.Play();
                    sceneImage.BackgroundImage = Properties.Resources.creepy_figure;
                    break;
                case 27:
                    outputLabel.Text = "You keep looking when you notice the shadow of a man creeping up behind you. Guess you should've gotten out when you had he chance... Play again?";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    evilLaugh.Play();
                    sceneImage.BackgroundImage = Properties.Resources.creepy_figure;
                    break;
                case 28:
                    outputLabel.Text = "You go to the garage and see the vehicle. You also notice a sword hung up on the rack on the wall. You feel like it may provide some defense. Do you get in the vehicle or check out the sword";
                    redOutputLabel.Text = "Check out the sword";
                    blueOutputLabel.Text = "Get in the vehichle";
                    SoundPlayer footsteps = new SoundPlayer(Properties.Resources._360800__kupp2__light_footsteps);
                    footsteps.Play();
                    break;
                    sceneImage.BackgroundImage = Properties.Resources.car_in_garage;
                case 29:
                    outputLabel.Text = "You get in the car and start it. You slam on the gas and go right through the front gate. You escaped. Congratulations!";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    SoundPlayer carEngine = new SoundPlayer(Properties.Resources._458461__prometheus888__carengine);
                    carEngine.Play();
                    sceneImage.BackgroundImage = Properties.Resources.car_leaving;
                    break;
                case 30:
                    outputLabel.Text = "You walk over to the sword to examine it. As you approach it, you step on a trip wire and fall down a pit. Play again?";
                    redOutputLabel.Text = "";
                    blueOutputLabel.Text = "";
                    evilLaugh.Play();
                    sceneImage.BackgroundImage = Properties.Resources.pit_fall;
                    break;
               

            }
        }
    }
}
