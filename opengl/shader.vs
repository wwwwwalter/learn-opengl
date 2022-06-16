#version 330 core
layout (location = 0) in vec3 aPos;   // 位置变量的属性 位置值为 0 
layout (location = 0) in vec3 aNormal;

out vec3 FragPos;
out vec3 Normal;


uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

void main()
{
    FragPos = vec3(model * vec4(aPos,1.0));
    Normal = aNormal;
    gl_Position = projection * view * model * vec4(aPos, 1.0);
}