#version 330 core
out vec4 FragColor;  


in vec2 TexCoord;

uniform sampler2D texture1;



void main()
{
    //FragColor = vec4(ourColor, 1.0);
    //FragColor = texture(ourTexture,TexCoord);
    //FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.5);
    FragColor = texture(texture1,TexCoord);
}