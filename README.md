<p align="center">
<a href="https://git.io/typing-svg"><img src="https://readme-typing-svg.demolab.com?font=Fira+Code&pause=1000&center=true&vCenter=true&random=false&width=450&lines=Car+Obstacle+Game" alt="Typing SVG" /></a>
</p>

<div align="center">
<img alt="GitHub code size in bytes" src="https://img.shields.io/github/languages/code-size/CptDat9/unity_car_obstacle_game_IT2000?labelColor=7AA2E3&color=97E7E1">
</div>                                  
## Giới thiệu

Game Xe Vượt Chướng Ngại Vật là một trò chơi 3D được phát triển bằng Unity. Trong game, người chơi sẽ điều khiển một chiếc xe thể thao trên con đường đầy rẫy chướng ngại vật. Mục tiêu của trò chơi là tránh các chướng ngại vật và đi được quãng đường xa nhất có thể mà không bị va chạm.

## Cấu trúc thư mục

Dưới đây là cấu trúc thư mục của dự án và mô tả ngắn về các tập tin, thư mục:

- **Materials**:
  - `road texture.jpg`: Hình ảnh texture của đường.
  - `road texture.mat`: Vật liệu sử dụng cho texture của đường.
  - `road texture.mat.meta`: Metadata của vật liệu đường.

- **Scenes**:
  - `Sport Car - 3D model`: Mô hình xe thể thao.

- **Flares**: Chứa các hiệu ứng ánh sáng.

- **Scripts**:
  - `CameraScript.cs`: Script điều khiển camera xoay quanh xe bằng chuột.
  - `LightEffects.cs`: Script quản lý hiệu ứng ánh sáng trong game.
  - `EnemyCallBack.cs`: Script quản lý hành vi của chướng ngại vật.
  - `Limitplayer.cs`: Script giới hạn vị trí của xe trong game.
  - `PlayerTrigger.cs`: Script xử lý va chạm và các sự kiện liên quan đến người chơi.
  - `RestartButton.cs`: Script điều khiển nút restart của game.

- **Other Files**:
  - `Lights example.unity.meta`: Metadata của scene mẫu về ánh sáng.
  - `Lights exampleSettings.lighting`: Cài đặt ánh sáng của scene mẫu.

## Hướng dẫn chơi

- Sử dụng chuột để điều khiển xe di chuyển trên đường.
- Tránh các chướng ngại vật trên đường đi.
- Nếu đến được cuối đường mà không va chạm vào chướng ngại vật, bạn sẽ chiến thắng.

### Điều khiển Camera

- **CameraScript.cs**: Script này giúp người chơi điều khiển camera xoay quanh xe bằng cách nhấn giữ chuột trái và di chuyển chuột theo trục X.
  - `RotateTarget`: Đối tượng mà camera sẽ xoay quanh (thường là chiếc xe).
  - `cameraRotateSpeed`: Tốc độ xoay của camera, có thể tùy chỉnh theo nhu cầu.

### Các chức năng khác

- **LightEffects.cs**: Điều khiển các hiệu ứng ánh sáng trong game.
- **EnemyCallBack.cs**: Quản lý hành vi và sự xuất hiện của các chướng ngại vật.
- **Limitplayer.cs**: Giới hạn khu vực mà xe có thể di chuyển.
- **PlayerTrigger.cs**: Xử lý các sự kiện khi xe va chạm với chướng ngại vật.
- **RestartButton.cs**: Cho phép người chơi khởi động lại game sau khi kết thúc.

## Yêu cầu hệ thống

### Yêu cầu tối thiểu:

- **Hệ điều hành**: Windows 10, macOS 10.14+, Ubuntu 20.04+
- **CPU**: Intel Core i5-2400 / AMD FX-8320 hoặc tương đương
- **RAM**: 8 GB
- **Dung lượng ổ cứng**: 2 GB dung lượng trống
- **Phần mềm**: Unity 2019.4 LTS trở lên

### Yêu cầu đề nghị:

- **Hệ điều hành**: Windows 10/11, macOS 11+, Ubuntu 22.04+
- **CPU**: Intel Core i7-6700K / AMD Ryzen 5 3600 hoặc tương đương
- **RAM**: 16 GB
- **GPU**: NVIDIA GeForce GTX 1060 / AMD Radeon RX 580 hoặc tương đương với 4 GB VRAM
- **Dung lượng ổ cứng**: 4 GB dung lượng trống
- **Phần mềm**: Unity 2020.3 LTS trở lên

## Minh họa

![image](https://github.com/user-attachments/assets/51f79110-8d6f-48ad-8597-28d70e6da654)
## Hướng dẫn cài đặt

1. Clone hoặc tải xuống mã nguồn của dự án.
2. Mở dự án bằng Unity.
3. Thiết lập các đối tượng trong Scene nếu cần thiết.
4. Chạy thử nghiệm và điều chỉnh các script nếu cần.

## Đóng góp

Nếu bạn muốn đóng góp vào dự án, vui lòng tạo một nhánh mới, thực hiện thay đổi và gửi pull request.



