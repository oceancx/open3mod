///////////////////////////////////////////////////////////////////////////////////
// Open 3D Model Viewer (open3mod) (v0.1)
// [TabUISkeleton.cs]
// (c) 2012-2013, Alexander C. Gessler
//
// Licensed under the terms and conditions of the 3-clause BSD license. See
// the LICENSE file in the root folder of the repository for the details.
//
// HIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE 
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; 
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT 
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS 
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
///////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Graphics;

namespace open3mod
{
    public partial class TabUiSkeleton : UserControl
    {
        private bool _loadCalled;

        public TabUiSkeleton()
        {
            InitializeComponent();
        }


        public SplitContainer GetSplitter()
        {
            return splitContainer;
        }


        public InspectionView GetInspector()
        {
            return inspectionView1;
        }


        public void InjectGlControl(GLControl gl)
        {
            var s = splitContainer.Controls[0];

            s.Controls.Add(gl);
            gl.Left = s.Left;
            gl.Top = s.Top;

            gl.Width = s.Width;
            gl.Height = s.Height;
        }

     
        private void OnLoad(object sender, EventArgs e)
        {
        }


        private void OnSplitterMove(object sender, SplitterEventArgs e)
        {
            // for some reason this is necessary to keep the layout from breaking up.
            inspectionView1.ClientSize = splitContainer.Panel2.ClientSize;
        }    
    }
}

/* vi: set shiftwidth=4 tabstop=4: */ 