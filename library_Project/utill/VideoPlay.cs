using DirectShowLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_Project.utill {
    internal class VideoPlay {

        string filePath = "D:\\YesoRYes.wmv";

        //파일 랜더링 그래프 생성
        IGraphBuilder pGrahpBuilder = null;
        IMediaControl pMediaControl = null;
        IMediaEvent pMediaEvent = null;
       // EventCode eventCode;
        IVideoWindow pVideoWindow = null;

        Panel panel = null;

        public VideoPlay(Panel panel) {
            this.panel = panel;

            pGrahpBuilder = (IGraphBuilder)new FilterGraph();

            pMediaControl = (IMediaControl)pGrahpBuilder;

            pMediaEvent = (IMediaEvent)pGrahpBuilder;

            pVideoWindow = (IVideoWindow)pGrahpBuilder;

            pMediaControl.RenderFile(filePath);

            //재생
            pVideoWindow.put_Owner(panel.Handle);
            pVideoWindow.put_WindowStyle(WindowStyle.Child | WindowStyle.ClipSiblings);
            Rectangle rect = panel.ClientRectangle;
            pVideoWindow.SetWindowPosition(0, 0, rect.Right, rect.Bottom);
            pMediaControl.Run();
            Console.WriteLine(pMediaControl.Run());
        }
    }
}
