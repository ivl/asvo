/*
 * SkinnedModelBoneWriter.cs
 * Authors:  Bruno Evangelista
 *           Rodrigo 'r2d2rigo' D�az
 * Copyright (c) 2008 Bruno Evangelista. All rights reserved.
 * Copyright (c) 2010 Rodrigo 'r2d2rigo' D�az. All rights reserved.
 *
 * THIS SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
 * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 * IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
 * CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
 * TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
 * SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 */
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using XNAnimation.Pipeline;

namespace XNAnimationPipeline.Pipeline
{
    [ContentTypeWriter]
    internal class SkinnedModelBoneWriter : ContentTypeWriter<SkinnedModelBoneContent>
    {
        protected override void Write(ContentWriter output, SkinnedModelBoneContent value)
        {
            value.Write(output);
        }

        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            return AssemblyHelper.GetRuntimeReader(typeof (SkinnedModelBoneReader), targetPlatform);
        }
    }
}