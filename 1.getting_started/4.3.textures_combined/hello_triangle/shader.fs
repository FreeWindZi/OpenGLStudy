#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

// texture samplers
uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
    // linearly interpolate between both textures (80% container, 20% awesomeface)
    
    //FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);

    //ÕýÃæÍ¼Æ¬
 
    vec2 texCoord = vec2(TexCoord.x, 1.0f - TexCoord.y);
    FragColor = mix(texture(texture1, texCoord), texture(texture2, texCoord), 0.2);
}