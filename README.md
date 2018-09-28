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

This illustrates that size and distance of objects are also determined in relation to each other. Visual cues (for instance, far-away objects appearing smaller and near objects appearing larger) develop in the early years of life and are vital in our perception. Convergence upon a single point is another visual cue that provides information about distance. As objects move farther away into the distance, they converge into a single point. Optical illusions, such as the Ames Room, show how our perception of size is altered by the relative sizes of other objects around us, as two perfectly equal figures have seemingly significant different sizes due to their differenet distances, which is camouflaged by the illusion.

As LaValle (2016) describes, VR itself can be considered as a grand optical illusion. 

What experiment did we set up, what do we want to measure, how do we measure it, how do we document it??
