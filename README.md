# CS370_ARMUSEUM

# iOS AR_MUSEUM 1.1
## (4/20/2024) Update Version 1.1.1
updates: ARInteraction is done, fixed Sam animation violating rotation problem.
Works needs being done...(priority high to low): 
### Must be done before Final presentation:
    Tutorial, Import artist models and patterns
    
## (4/16/2024) Update Version 1.1.0
updates: Idle Animation for bird
Known bug: under some angle, some other models might be shown

### Google drive download 1.1.0 Unity file
https://drive.google.com/file/d/1CrJBpUETG2nnEP3KZzVPamSCG0ay2vd9/view?usp=sharing
### Google drive download 1.1.0 build file
https://drive.google.com/file/d/1TzpoGUMlFw4AO2LuCAhTHfV88EVg236M/view?usp=sharing



# iOS AR demo 1.0

## （4/5/2024） Update Version 1.0.9
updates: It was windy that day, so I dragged a plastic chair on my balcony, putted my sun glasses on, and sat on that plastic chair. The wind is like a messenger, they told me "I AM THE STORM THAT IS APPROACHING, PROVOKING, BLACK CLOUDS IN ISOLATION!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
and ARinteract is now available(also lower the volume while using the app)
Works needs being done...(priority high to low): 

### Google drive download 1.0.9 Unity file
https://drive.google.com/file/d/1CrJBpUETG2nnEP3KZzVPamSCG0ay2vd9/view?usp=sharing
### Google drive download 1.0.9 build file
https://drive.google.com/file/d/1Cuz6pzcNsq-8o-lqxEMVYz8rg6ja5mrz/view?usp=sharing

## （4/4/2024） Update Version 1.0.8
updates: removed the cringe model, added three models in both display room and ARCamera. And give me the Yamato
### Google drive download 1.0.8 Unity file
https://drive.google.com/file/d/1CrJBpUETG2nnEP3KZzVPamSCG0ay2vd9/view?usp=sharing
### Google drive download 1.0.8 build file
https://drive.google.com/file/d/1NhZfOIamKygiJk9UlrI_X6UgEx2G3yfM/view?usp=sharing

## （4/4/2024） Update Version 1.0.7
updates: optimized switch scene toggle display effect, added select previous model arrow, changed next model button to next model arrow, fixed sometimes the model switch disappear problem.
### Google drive download 1.0.7 Unity file
https://drive.google.com/file/d/1W2e49M-GG9BRNHSzQPDDFW9dG-rYGVTh/view?usp=sharing

## （4/3/2024） Update Version 1.0.5
updates: corrected opening, added description toggle animation, corrected description toggle display logic, moved switch scene toggle to match the mockup, optimized switch model button display effect.
### Google drive download 1.0.5 Unity file
https://drive.google.com/file/d/1fUyhzcWXIdegDTq7d10gpY5PchpApC0f/view?usp=sharing

## (3/25/2024) Update Version 1.0.4
updated display room that allows the player to rotate the model(rotate in X direction).
updated description panel.
### Google drive download 1.0.4 build file
https://drive.google.com/file/d/1pRLN6JnPXfRf1jFBBmZ0NPYjFPTKhJH_/view?usp=sharing
### Google drive download 1.0.4 Unity file
https://drive.google.com/file/d/1CrJBpUETG2nnEP3KZzVPamSCG0ay2vd9/view?usp=sharing
### Unity version download
https://unity.com/releases/editor/archive
find 2020.3.24 do 64-bit

## (3/7/2024) Update Version 1.0.2
### IMPORTANT: Software
Please use Unity 2020.3.24f1 (64-bit) for this project. Xcode version 14 or 15 both supports the Unity build file, which means, the program supports from iOS 12 to iOS 17. But if you want to install to iOS 17, use Xcode 15 for sure.

### Testing
DO NOT PUT TWO PATTERNs TOO CLOSE!!! If two pattern looks alike, it will display the wrong model, because it recongnize the pattern but the old model did not go away. So the best solution is to not use similar pattern. I used similar pattern just to test if it can correctly recongnize the pattern. Also, it does not allow multi image recongnition and model display. I mean from the bright side, it does not look chaotic.

### Models 
Used fbx format, haven't try other format yet. Also, do not make the model too tall. The anime girl model is an example. That model can easily get some placement glitch for some reason. But the bird one (I guess its a bird) is better.

### AR feature
Used vuforia package to support all the features, used ARCamera(required) and target image(image recongnition). Make sure put the model under target image for tracking feature.

### Unity build file
make sure the lowest iOS version is 12, and support AR-kit, and allow auto-sign. Then use the iOS platform to build

### How to compile and install into your iphone
So when u got Xcode and the zip file downloaded, unzip the build file, and then click the icon that has the Xcode icon. 
When the file is opened in Xcode, at the very left, you see a list, click Unity-iPhone , then the middle part of the window will change, click Signing&Capabilities. 
Change the Bundle Identifier, you can change it to anything you want, as long as it’s not the same as the original(recommend just add a few numbers at the end).
At signing certificates, log in as yourself
Then connect your iPhone with your Mac, make sure you clicked trust this device on your iPhone. 
At the every top, you see an unity icon followed by “Unity-IPhone” followed by an arrow, click on this, change the object on the right hand side of the arrow to your phone.
At the upper left hand Conor you will see a play botton. Click on it, then it should start compiling.

After it compiled, the file will be transfered to your phone.
Go to your phone, setting, general, VPN&Devicd management, trust our application, then go back to the Mac, click the play button again, it should fully install this time.

### 1.0.2 build file
https://drive.google.com/file/d/1CrJBpUETG2nnEP3KZzVPamSCG0ay2vd9/view?usp=sharing

### resources for artist to referrence
We are using fbx format, haven't try other formats yet. The pattern is not included in this file, but it has to be JPG or PNG images in RGB or grayscale. The size of the input images must be 2.25 MB or less and have a minimum width of 320 pixels.
https://drive.google.com/file/d/17HDIvnG5FUlcTjoQ9Vs7wUo9m5H1IuBG/view?usp=sharing

### resouces for unity
Included the Vuforia package and target image(the patterns).
https://drive.google.com/file/d/1nmOYC7SnU5J_aWuC_r2ilQbiGh52XEkv/view?usp=sharing

### unity files
put it into your U_project
https://drive.google.com/file/d/159pkQo2ID6HdVGDIBkeS9Ez2TXghDJ50/view?usp=sharing
