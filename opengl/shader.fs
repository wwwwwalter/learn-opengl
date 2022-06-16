#version 330 core
out vec4 FragColor;


uniform vec3 objectColor;
uniform vec3 lightColor;



void main()
{
    //FragColor = vec4(ourColor, 1.0);
    //FragColor = texture(ourTexture,TexCoord);
    //FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.5);
    //FragColor = texture(texture1,TexCoord);
    FragColor = vec4(lightColor * objectColor, 1.0);
}