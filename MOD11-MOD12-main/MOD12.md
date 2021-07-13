# Module 12: Animating the User Interface
Wherever a path to a file starts with *[Repository Root]*, replace it with the absolute path to the folder in which the 20480 repository resides. For example, if you cloned or extracted the 20480 repository to **C:\Users\John Doe\Downloads\20480**, change the path: **[Repository Root]\AllFiles\20480C\Mod01** to **C:\Users\John Doe\Downloads\20480\AllFiles\20480C\Mod01**.

# Lesson 1: Applying CSS Transitions

### Demonstration: Using CSS Transitions

#### Preparation Steps 

Ensure that you have cloned the 20480C directory from GitHub (**https://github.com/MicrosoftLearning/20480-Programming-in-HTML5-with-JavaScript-and-CSS3/tree/master/Allfiles**). It contains the code segments for the labs and demos in this course.

#### Demonstration Steps

#### Apply CSS Transitions to HTML Elements

1. On the Start screen, click the **Desktop** tile.

2. On the Windows taskbar, click **Microsoft Edge**.

3. In Microsoft Edge, open the file **[Repository Root]\Allfiles\Mod12\Democode\Transitions.html**. 

   ![image-20200930114219253](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930114219253.png)

4. If a message box appears asking if you want to allow blocked content, click **Allow blocked content**.

5. Place the mouse pointer over the upper rectangle on the web page. Verify that the following transitions are applied simultaneously to the rectangle:
- The width, height, and font size increase over a period of two seconds.

- The background color transitions to red over a period of 3.75 seconds.

  ![image-20200930114307010](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930114307010.png)
6. Move the mouse pointer away from the upper rectangle. Verify that the rectangle reverts to its original appearance, over the same period of time.

   ![image-20200930114353431](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930114353431.png)

7. Repeat the previous two steps for the second rectangle. Verify that the same animations apply.

8. Right-click the page in Microsoft Edge and then click **View source**. Note that:
- The first **div** rule defines default CSS properties for all the **&lt;div&gt;** elements.

- The **div.simple** rule defines a **transition** property that applies to transitions on the **width**, **height**, **font-size**, and **background-color** CSS properties.

- The **div.complex** rule defines similar transitions, but it uses separate **transition-property**, **transition-duration**, **transition-timing-function**, and **transition-delay** properties.

- The **div:hover** rule defines the final values for the **width**, **height**, **font-size**, and **background-color** CSS properties when the user places the mouse pointer over a **&lt;div&gt**

  ![image-20200930114533825](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930114533825.png)

#### Handle the Transitionend Event

1. In Microsoft Edge, expand the drop-down list box. Verify that it displays messages for all the transitions that have ended. The list includes events for the original transitions when you place the mouse pointer over a rectangle, as well as events for the reverse transitions when you move the mouse pointer away from a rectangle.

   ![image-20200930114623580](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930114623580.png)

2. Switch to the source window.

3. In the JavaScript code, note that:
- The **onLoad()** function sets up event-handlers that call the **onTransitionend()** function when the **transitionend** event is raised on all the **&lt;div&gt;** elements.

- The **onTransitionend()** function displays information about the **transitionend** event, by using the **propertyName** and **elapsedTime** properties of the event argument.

  ![image-20200930114706510](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930114706510.png)
4.	Close the source window.
5.	Close Microsoft Edge.

# Lesson 2: Transforming Elements

### Demonstration: Performing 2D Transformations

#### Preparation Steps 

Ensure that you have cloned the 20480C directory from GitHub (**https://github.com/MicrosoftLearning/20480-Programming-in-HTML5-with-JavaScript-and-CSS3/tree/master/Allfiles**). It contains the code segments for the labs and demos in this course. 

#### Demonstration Steps

#### Perform 2D Translations

1. On the Start screen, click the **Desktop** tile.

2. On the Windows taskbar, click **Microsoft Edge**.

3. In Microsoft Edge, open the file **[Repository Root]\Allfiles\Mod12\Democode\2DTranslations.html**. 

4. If a message box appears asking if you want to allow blocked content, click **Allow blocked content**.

   ![image-20200930114746583](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930114746583.png)

5. Verify that the browser displays a series of rectangles. Each rectangle demonstrates how to perform a 2D translation by using the **translate()**, **translateX()**, or **translateY()** functions. The text message inside each rectangle describes the transformation for that rectangle.

6. Right-click in the browser window, and then select **View source**. 

7. In the source window, scroll down to the bottom of the document. Note that the body of the document has a series of **&lt;div&gt;** elements and each element has a distinct CSS class.

   ![image-20200930114901154](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930114901154.png)

8. Scroll up to the top of the code, and then locate the **&lt;style&gt;** element. The CSS rules implement translations for all the **&lt;div&gt;** elements. The CSS rules set the standard **transform** property as well as the following vendor-specific properties:
- **-ms-transform**: Perform a transformation on Microsoft Edge 9.

- **-webkit-transform**: Perform a transformation on Webkit-based browsers such as Chrome and Safari.

- **-moz-transform**: Perform a transformation on Mozilla browsers.

- **-o-transform**: Perform a transformation on Opera browsers.

  ![image-20200930114926324](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930114926324.png)
9.	Close the source window.

#### Perform 2D Scaling Transformations

1. In Microsoft Edge, open the file **[Repository Root]\Allfiles\Mod12\Democode\2DScaling.html**. 

2. Verify that the browser displays a series of rectangles. Each rectangle demonstrates how to perform a 2D scaling transformation by using the **scale()**, **scaleX()**, or **scaleY()** functions. The text message inside each rectangle describes the transformation for that rectangle. 

   ![image-20200930115722668](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930115722668.png)

3. Right-click in the browser window, and then select **View source**. 

4. In the source window, scroll down to the bottom of the document. Note that the body of the document has a series of **&lt;div&gt;** elements and each element has a distinct CSS class.

   ![image-20200930115808085](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930115808085.png)

5. Scroll up to the top of the code and locate the **&lt;style&gt;** element. The CSS rules implement scaling transformations for all the **&lt;div&gt;** elements. The CSS rules set the standard **transform** property as well as vendor-specific properties.

   ![image-20200930115840787](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930115840787.png)

6. Close the source window.

#### Perform 2D Rotations

1. In Microsoft Edge, open the file **[Repository Root]\Allfiles\Mod12\Democode\2DRotations.html**. 

2. Verify that the browser displays a series of rectangles. Each rectangle demonstrates how to perform a 2D rotation by using the **rotate()** function. The fourth rectangle also shows how to perform multiple transformations, and how to change the origin of the transformation to the top left of the target element.

   ![image-20200930115901258](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930115901258.png)

3. Right-click in the browser window, and then select **View source**. 

4. In the source window, scroll down to the bottom of the document. Note that the body of the document has a series of **&lt;div&gt;** elements and each element has a distinct CSS class.

   ![image-20200930115936730](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930115936730.png)

5. Scroll up to the top of the code, and then locate the **&lt;style&gt;** element. The CSS rules implement rotations for all the **&lt;div&gt;** elements. The CSS rules set the standard **transform** property as well as vendor-specific properties. The final CSS rule shows how to apply multiple transformations, specifically a translation followed by a rotation. The final CSS rule also shows how to set change the origin of the transformation by setting the **transform-origin** property and its vendor-specific equivalent properties.

   ![image-20200930120011581](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120011581.png)

6. Close the source window.

#### Perform 2D Skewing Transformations

1. In Microsoft Edge, open the file **[Repository Root]\Allfiles\Mod12\Democode\2DSkewing.html**. 

2. Verify that the browser displays a series of rectangles. Each rectangle demonstrates how to perform a 2D skewing operation by using the **skew()**, **skewX()**, or **skewY()** functions. 

   ![image-20200930120042255](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120042255.png)

3. Right-click in the browser window, and then select **View source**. 

4. In the source window, scroll down to the bottom of the document. Note that the body of the document has a series of **&lt;div&gt;** elements and each element has a distinct CSS class.

   ![image-20200930120119781](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120119781.png)

5. Scroll up to the top of the code, and then locate the **&lt;style&gt;** element. The CSS rules implement skewing transformations for all the **&lt;div&gt;** elements. 

   ![image-20200930120147056](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120147056.png)

6. Close the source window.

7. Close Microsoft Edge.

>**Note**: Some of the transformations in this demonstration cause the target elements to appear partially off the screen.

### Demonstration: Performing 3D Transformations

#### Preparation Steps 

Ensure that you have cloned the 20480C directory from GitHub (**https://github.com/MicrosoftLearning/20480-Programming-in-HTML5-with-JavaScript-and-CSS3/tree/master/Allfiles**). It contains the code segments for the labs and demos in this course.

#### Demonstration Steps

#### Perform 3D Transformations that Include Transitions

1. On the Start screen, click the **Desktop** tile.

2. On the Windows taskbar, click **Microsoft Edge**.

3. In Microsoft Edge, open the file **[Repository Root]\Allfiles\Mod12\Democode\3DTransformations.html**. 

4. If a message box appears asking if you want to allow blocked content, click **Allow blocked content**.

5. Verify that the browser displays a cube. There are six faces to the cube, each of which displays text and has a different background color. The front face is partially transparent so that it does not completely obscure the other faces.

   ![image-20200930120211540](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120211540.png)

6. Place the mouse pointer over the cube. Verify that it rotates by 90 degrees over a period of five seconds. Then, move the mouse pointer off the cube, and then verify that the cube rotates smoothly back to its original position.

7. ![image-20200930120308504](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120308504.png)

   ![image-20200930120347479](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120347479.png)

8. Right-click in the browser window, and then select **View source**. 

9. In the source window, scroll down to the bottom of the document. Note that the body of the document has six **&lt;div&gt;** elements that represent the six faces of the cube. These **&lt;div&gt;** elements are contained in a parent **&lt;div&gt;** element named **container**.

   ![image-20200930120426080](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120426080.png)

10. Scroll up to the top of the code, and then locate the **&lt;style&gt;** element. Note the following CSS rules:
- **#container**: Specifies a perspective for all the child elements of the **container** element, and a transition of five seconds for transformations.

  ![image-20200930120447985](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120447985.png)

- **#container:hover**: Specifies a rotation of 90 degrees when the user places the mouse pointer over the **container** element.

  ![image-20200930120456836](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120456836.png)

- **#rightFace**: Transforms the **rightFace** element in 3D space, so that it appears on the right side of the cube.

  ![image-20200930120505833](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120505833.png)

- **#leftFace**: Transforms the **leftFace** element in 3D space, so that it appears on the left side of the cube.

  ![image-20200930120514705](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120514705.png)

- **#topFace**: Transforms the **topFace** element in 3D space, so that it appears on the top of the cube.

  ![image-20200930120535990](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120535990.png)

- **#bottomFace**: Transforms the **bottomFace** element in 3D space, so that it appears on the bottom of the cube.

  ![image-20200930120545197](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120545197.png)

- **#backFace**: Transforms the **backFace** element in 3D space, so that it appears at the back of the cube.

  ![image-20200930120552557](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120552557.png)

- **#frontFace**: Transforms the **frontFace** element in 3D space, so that it appears at the front of the cube. The background color is partially transparent.

  ![image-20200930120559971](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120559971.png)
10. Close the source window.
11. Close Microsoft Edge.

# Lesson 3: Applying CSS Keyframe Animations

### Demonstration: Implementing Keyframe Animations

#### Preparation Steps 

Ensure that you have cloned the 20480C directory from GitHub (**https://github.com/MicrosoftLearning/20480-Programming-in-HTML5-with-JavaScript-and-CSS3/tree/master/Allfiles**). It contains the code segments for the labs and demos in this course. 

#### Demonstration Steps

#### Define and Run a Keyframe Animation

1. On the Start screen, click the **Desktop** tile.

2. On the Windows taskbar, click **Microsoft Edge**.

3. In Microsoft Edge, open the file **[Repository Root]\Allfiles\Mod12\Democode\KeyframeAnimations.html**. 

4. If a message box appears asking if you want to allow blocked content, click **Allow blocked content**.

5. Verify that a green rectangle appears on the page, with a small white circle in the top left corner. The green rectangle represents a pool table and the white circle represents a ball. There is also a button that enables you to start the animation.

   ![image-20200930120624421](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120624421.png)

6. Click **Start Animation**. 
- After three seconds, the ball starts moving diagonally on the pool table. The color of the pool table also changes to blue and a message appears at the bottom of the page to indicate the start time of the animation.

  ![image-20200930120700925](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120700925.png)

  ![image-20200930120708805](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120708805.png)

  ![image-20200930120716443](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120716443.png)

  ![image-20200930120759770](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120759770.png)

  ![image-20200930120832751](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120832751.png)

- As the animation proceeds, the ball appears to bounce off the sides of the pool table and the color of the ball varies from white to yellow, then to orange, then to red, and then finally to purple.

- When the ball reaches the bottom right corner of the pool table, a message appears to indicate that the first iteration of the animation has completed. The next iteration of the animation begins; this iteration plays the animation in reverse so that the ball ends up in its original position with its original color. 

- At the end of the animation, the pool table reverts to green and messages appear at the bottom of the page to indicate the elapsed time of the animation.
7. Right-click in the browser window, and then select **View source**. 

8. In the source window, scroll down to the bottom of the document. Note that the body of the document has a **&lt;div&gt;** element named **pooltable** that represents the pool table and a nested **&lt;div&gt;** named **ball** that represents the ball on the pool table. There is also a **&lt;button&gt;** element to start the animation, and a **&lt;div&gt;** named **messageLabel** where messages are displayed.

   ![image-20200930120919096](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120919096.png)

9. Scroll up to the top of the file, and then locate the **&lt;style&gt;** element. Note the following CSS rules:
- **#pooltable**: Specifies the initial appearance of the pool table.

  ![image-20200930120934535](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120934535.png)

- **#pooltable.animate**: Specifies a different color for the pool table during an animation. There is JavaScript code elsewhere in the document that programmatically adds the **animate** class to the **pooltable** element when an animation starts to cause the pool table to turn blue during an animation.

  ![image-20200930120942398](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120942398.png)

- **#ball**: Specifies the initial appearance of the ball.

  ![image-20200930120952041](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930120952041.png)

- **@-ms-keyframes ballmovement**: Defines a keyframe animation named **ballmovement**. The first rule-set specifies the original color and location of the ball. Each subsequent rule-set simulates the ball hitting one of the sides of the pool table and causes the ball to change color during each part of its journey. The final rule-set specifies the final color and location of the ball.

  ![image-20200930121038798](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930121038798.png)

- **#ball.animate**: Applies the **ballmovement** keyframe animation to a ball when the ball has the **animate** class. There is JavaScript code elsewhere in the document that programmatically adds the **animate** class to the **ball** element when the user clicks the **Start Animation** button to trigger the animation.

  ![image-20200930121052855](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930121052855.png)
10. Locate the **&lt;script&gt;** element. Note that:
- The **init()** function, invoked as soon as the page has loaded, establishes event-handler functions for the **MSAnimationStart**, **MSAnimationIteration**, and **MSAnimationEnd** events on the **ball** element: 

  ![image-20200930121121851](C:\Users\Juanjo\AppData\Roaming\Typora\typora-user-images\image-20200930121121851.png)

- The **MSAnimationStart** event-handler function is called when an animation starts on the **ball** element. The function adds the **animate** class to the pool table so that the pool table becomes blue. The function also displays a message to indicate the time when the animation started.

- The **MSAnimationIteration** event-handler function is called when each iteration of the animation has completed. The function displays a message to indicate the elapsed time of the animation.

- The **MSAnimationEnd** event-handler function is called when an animation ends on the **ball** element. The function enables the button, removes the **animate** class from the ball and the pool table, and then displays a message to indicate the elapsed time of the animation.

- The **startAnimation()** function is Invoked when the user clicks the **Start Animation** button. The function disables the button and adds the **animate** class to the ball to trigger the animation. The animation starts three seconds later, due to the **-ms-animation-delay: 3s;** property in the **#ball.animate** CSS rule.
11. Close the source window.
12. Close Microsoft Edge.


