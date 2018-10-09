# AmesRoom
IDS6938 - Mixed Reality for Modeling and Simulation


## Our first project will recreate the "Ames Room" within Virtual Reality (VR).

We will then try to **change the parameters** of the traditional Ames Room, which is a static spatially distorted room, viewed from a single viewing point (door peepkole perspective), into a **variation within VR**.

# The Ames Room Illusion
## An example for the limits and the possibilities of visual perception

The human **perception is dependent on several factors**, like distance, depth, scale, motion, angle, colors and light. Probably the most important factor is context, which improves our understanding of the visually perceived information. 

An excellent demonstration on how all these aspects can be used to fail our perception is the **Distorted Room Illusion (DRI)** (Runeson, 1988), of which the Ames Room is one of the most prominent. Even though these very unregular DRI room layouts (nonrectangular, shape inconsistent) consist mainly of trapezoidal surfaces, they create the illusion of a normal, rectangular and evenly shaped room, with normal measurements, angles and ratio. 

Due to the layout and spacial distortion inside the room, the persons or objects inside of it can appear “out of sync with the environment” with being unusual large or small, depending on where in the room they are located. When moving, these persons/objects even appear to change their own size while doing so, as logic and our experience dictate that the a room is static and stable. 

As a **prerequisite for this illusion** to work, it is mandatory that these **DRI are viewed from a designated point** and predetermined aspect angle in the room or even better, just a door-peephole through one of the walls. The success of traditional DRI (Ames room) is largely driven by incorrect depth cues, which results in incorrect size perception. 
LaValle (2016) explains that the viewer, in order to estimate the size or distance (which relates to size of an object by performing size consistency scaling), must be **familiar with the objects** and have a general idea about its true size. Additionally, the object/**scenery has to appear natural**, so it doesn’t conflict with the other depth cues in the vicinity. 
If there is uncertainty about the size of an object, the viewer will use the distance (if known) to improve his size perception, since he can use his experience and **knowledge of objects and put them into size-distance context**. The farther objects are away, the smaller they seem. If they appear huge even being far away, the size must obviously be tremendous. 


![Size and Distance by experience](https://github.com/valdeezzee/AmesRoom/blob/master/Ames%20Room%20Readings/Huge_Rubber_Duck.jpg)

This effect is strongly used by the monocular view for the Ames room, because monocular view partly impairs distance perception. Distance, up to a certain point (until distance becomes indistinguishable), is one of the additional information gained by stereo view (both eyes in use). **Binocular disparity** (LaValle, 2016), which is the different viewpoint of the eyes due to their different position on the head, results in different images on the retinas and **provides necessary cues for depth and distances**. 
Viewing through a door peephole is a monocular activity. Therefore, it is easy and natural to utilize the geometric figures and layout of the Ames room as a “descriptive system” (Runeson, 1988) that allows the description and understanding of the spatial configuration of the DRI viewed through the hole. The context is utilized for the (monocular) viewer as a description of the actual physical reality, because it is not possible to distinguish distance and depth. 

The illusion will be hard to maintain when the viewer is involved more into the **perception of the room by using motion or binocular based information**. Motion through the DRI will change the aspect angles of view, binocular will collect more information of objects and therefore cues on size and depth. 
The Ames room is a specially modelled example where the viewer is deprived of all this (normally available) information and restricted to a monocular, motion independent, static viewpoint, which makes it almost impossible to discover the illusion without further sensory input. 


## Implications of depth perception on VR

Cues about the size and distance of objects are determined relative to the kown or estimated sizes and distances of other objects. It is part of our every day experience and knowlegde. Without this (unconscioulsy applied) experience, it would be hard to navigate in our environment. Cues can come from monocular or binocular perception. Monocular cues about size and shape are used in perceiving depth, like the spatial order (e.g. something is party covered so it has to be behind it, further away). Binocular vision compares the input from both eyes to create the perception of depth, or stereopsis by comparing (minimum differences in angle, light) visual input.
Stereopsis (the impression of depth) is perceived when the visual stimuli (such as distance, size, or shape) from each eye are compared binocularly (using both eyes). 

How does perception of images (seeing) work organically? 

It is when visual stimuli enter as light through the photoreceptors in the retina, where they are changed into neural impulses. These impulses travel through the central nervous system, to the thalamus, and then to the visual cortex. From the visual cortex, the information goes to the parietal lobe and the temporal lobe. Approximately one-third of the cerebral cortex plays a role in processing visual stimuli.

Our experiments and especially the Ames Room DRI are focussing on fooling the depth perception.  

Depth perception is the visual ability to perceive the world in three dimensions (in contrast to 2D pictures), coupled with the ability to estimate how far away an object is. The estimated size and distance of an object are obtained through both monocular and binocular cues (as stated above). But monocular vision is very poor at determining depth compared to binocular vision. When an image is projected onto a single retina, above mentioned cues about the relative size of the object compared to the environment (and its own experience/knowledge) and other (familiar) objects are obtained. In binocular vision, depth perception relies on the convergence of both eyes upon a single object, the relative differences between the shape and size of the images on each eye/retina these relative sizes (and angles) of each eye are compared. Other cues such as texture and constancy add to the overall information perception. The perceived angle difference between each eye becomes smaller and smaller the further away the object is located. 

![Ebbinghaus Illusion](https://github.com/valdeezzee/AmesRoom/blob/master/Ames%20Room%20Readings/1200px-Mond-vergleich.svg.png)

The Ebbinghaus illusion demonstrates how the perception relies upon context and comparison. The perceived size of an object is altered by the relative sizes of other, nerby objects. Even though the two center circles are of the same size, they seem to be of different sizes due to their surrounding area (context).

This illustrates that size and distance of objects are also determined in relation to each other. Visual cues (for instance, far-away objects appearing smaller and near objects appearing larger) develop in the early years of life and are vital in our perception. Convergence upon a single point is another visual cue that provides information about distance. As objects move farther away into the distance, they converge into a single point. Optical illusions, such as the Ames Room, show how our perception of size and depth is altered by the relative sizes of other objects around us, as two perfectly equal figures have seemingly significant different sizes due to their differenet distances, which is camouflaged by the illusion.

As LaValle (2016) describes, VR itself can be considered as a grand optical illusion. 


As a baseline for our experimetns, we established the Ames Room as a DRI in a Virtual Reality Environment.
The following Soft- and Hardware was used:


Hardware:
- Headset: LHR-31C144F7 Headset Vive. MV HTC

Software:
- Unity 2017.4.1f
- STEAM XXXXX


The software models of the different Ames Room set-ups are attached in the respective folders. For more detailed information on the set-up, please review "steamvr_report.txt" above. 

As described above, our main effort in this course so far and specifically with the Ames Room DRI is the process of human perception in conjunction with Virtual Reality technology. 
We focus our questions and experiment on how the Ames Room is perceived and which cues can be perceived and which cues and/or how many are necessary to "see through" the illusion.

We propose 3 experiments (A-C) to demonstrate the limits of perception within VR. 

Experiment (A): 

Depth perception in an Ames Room in VR. Distance estimation with the help of a moving object and controllable hand-eye activity. The question will be wether a simple VR environment delivers sufficient cues for a reliable depth perception, combined with the specifications of a DRI, in this case the Ames Room.  

This experiment will give the participant the possibility to play freeshot-basketball in VR, but the playfield will be an Ames Room DRI. 
    
    
Set-up:
    
+ The Ames Room will be set up with a basket in the (perceived) middle of the back wall and a resurecting ball at the predefined viewpoint for the DRI. 

+ The participant will be able to practise freeshots at the basket to familiarize himself with the VR technology (controller and glasses). The number of balls or the available time will be limited (tbd). 
        
+ The ball will fall through the floor and not bounce in order to hide the specifications of the (tilted/angled) room floor.
    
+ After the trial phase, the Ames Room will be reconfigured with 2 baskets, one close to each far corner of the room.
        
+ The participant will have to throw 10 (tdc) balls at each basket. All other settings will remain the same.
        
        
Objectives:

+ Our main objective for measurement in this experiment is supposed to be the participants depth perception, the ability to estimate distance (therefore translated to depth) and to realize that he has different distances due to a illusion. 
+ It is a two-stepped approach, im which first, he has to discover that the distances are not the same by the use of a moving and manipulateable object (ball), which offers additional cues (necessary strength, flight time of the ball, trajectory...). 
+ Secondly, the experiemt aims at his ability to conclude that the (expected) different freethrow results and effort is indeed the result of a manipulated perception of the room. 

Method:

- The participant can speak out about his experiences and his impression of the experiment while in VR. After the experiement a questionnaire will be given to quantify certain variables. The questions of the questionnaire will be quantitative, the verbal questions and responses during the exüeriment will be of qualitative nature, significant details concerning the perception will have to be noted and further analyzed. 
- As this is the first evolution and design, we are not aware of all information that could be gained by our experiment. 

- We consider the presented approach as a trial run to verify and further validate our design of the experiment.


Procedure:

+ The participants will be given an introduction into the VR hardware and the operation with the hand-hold controllers. 

+ No hint will be provided that the presented room could be anything other that it appears.

+ The participant will have limited, but sufficient time (tbd) to familiarize with the setting, equipment and throwing of the ball.

+ After familiarization phase, the participant will be briefed on the task to throw the given number balls into the baskets.

+ The number of achieved baskets will be counted.

+ Questions from a questionnaire will be asked concerning several aspects of the simulation and tasks (Questionnaire, see below).


Questionnaire:

The questions can be answered with yes/no, unless stated otherwise. The questions will be answered one after the other without going back to previous questions.

- Perception of Immersion into a VR environment

  - I had the feeling of being inside a virtual, 3D room/environment.
  - I had the feeling of a 2D/picture-like presentation only.
  - The environment felt like it could be touched.
  - It seemed realistic.
  - It almost made me forget that I am in a real room/laboratory.

- Operating in VR

  - The ball-throwing procedure is easy to understand 
  - I had no problems operating with the hand-held controllers.
  - It was hard to do repeatable ball shots on the same basket.

- Depth Perception:

  - The depth impression was realistic.
  - The presented objects were realistic in size.
  - The presented objects were realistic in behavior.
  - I was able to roughly estime the distance from me towards the baskets.
  - It was equally hard to score on both baskets. 
  - Both baskets had the same distance to me.
  - The left basket was roughly ___ ft away (insert estimated distance).
  - The right basket was roughly ___ ft away (insert estimated distance).
  - The room clearly had some unusual spacial traits.

Documentation:

- Ideally the communication during the whole experiment is recorded and analyzed for information on depth, perception and workability.
- The questionnaire will be performed by the experiment personell and the yes/no and the estimate (in feet) will be written directly on the questionnaire. Depending on the size of the participants, these variables will be futher analyzed, depending on the respective content. 
 
 
 
Experiment (B): 

Depth perception and overall perception of an Ames Room in VR. After the "Distance estimation experiment" (Experiment A), the participant will be familiar with the concept of an DRI. The question will be wether our a simple Ames Room can be distinguished from a normal, regular room that looks like the Ames Room. It is an experiment to validate the integrity of our construct and get an insight on how participant perceive different VR constructs after being aware of the possible illusions. 


This experiment will simply consits of 2 seemingly equal rooms, which the participant has to observe and make a decision which one is the DRI and which one is the "normal" room.
    
    
Set-up:
    
+ The participant will get 1 minute each (time tbd) to view/observe an Ames Room and  normal room. 
+ There is only one detail which will be different in order to better distinguish between both after the observation. 
+ After they have seen both, the get another minute (time tbd) each to verify their observations. 


Objectives:

+ Our main objective in this experiment is the validation of our Ames Room construct. Can it be distinguished in direct comparison to a normal, equally looking room. 
+ What are the cues that gave the DRI away, if any. 

Method:

- The participant can speak out about his experiences and his impression of the rooms while in VR. 
- After the experiment, the participant will have to decide which room was the DRI, There are three options:

  - Room 1
  - Room 2
  -I dont know.

- The participants then have to explain their decision/answer. This answer will also be recorded and analyzed. This will lead to either an improvement of the room or to the development of an quatitative questionnaire which incooperates the indentified (and other) mistakes in the construction. 

Procedure:

+ The participants will be given a short introduction into the VR hardware. The use of the hand-hold controllers will not be necessary. 

+ The Set-up will be explained (time) and that therre will be 2 seemingly equal, but different rooms.


Documentation:

- Ideally the communication during the whole experiment is recorded and analyzed for information on depth, perception and workability.
- The questionnaire will be performed by the experiment personell and the answers (to the three options and what gave it away) will be written directly on the questionnaire. 
 
 
 
Experiment (C): 

Depth perception and overall perception in VR. The concept to prove with the experiment is valid for any VR construct if the same prerequisites are adhered to. The question will be wether a change in size of a (simple Ames) Room can be recognized while being in VR. It is an experiment to validate the assumption that VR is not detailed enough and technically not capable to deliver the necessary cues  for true depth perception. 

This experiment will consits of the Ames Rooms, which the participant will observe while the room will be resized (significantly smaller/larger). 

    
Set-up:
    
+ The participant will observe the Ames Room. 
+ The size of the room will be changed while the participant is observing it.


Objectives:

+ Our main objective in this experiment is the validation/demonstration of the perception theory (see above in the theretical description of perception). 

Method:

- The participant is aware of the intended changes and he will have to look for any changes. 
- As in all Ames Room experiments, the vienwing angle/place to observe from has to be used, no movement  other than the head is permissible.
- The participants will speak as sson as he senses change. 

Procedure:

+ The participants will be given a short introduction into the VR hardware. The use of the hand-hold controllers will not be necessary. 

+ The Set-up will be explained (resizing) and the resizing will be introduced short after the participant is in VR and ready.


Documentation:

- The communication during the whole experiment is recorded. The expected result is no perceived change.

((Dr. Kider wants to know: What experiment did we set up, what do we want to measure, how do we measure it, how do we document it??))

