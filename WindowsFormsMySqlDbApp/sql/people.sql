/*
 Navicat Premium Data Transfer

 Source Server         : localhost_mysql_root
 Source Server Type    : MySQL
 Source Server Version : 80036
 Source Host           : localhost:3306
 Source Schema         : ytdemo

 Target Server Type    : MySQL
 Target Server Version : 80036
 File Encoding         : 65001

 Date: 09/03/2024 14:36:47
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for people
-- ----------------------------
DROP TABLE IF EXISTS `people`;
CREATE TABLE `people`  (
  `Id` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `LastName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `EmailAddress` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 33 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of people
-- ----------------------------
INSERT INTO `people` VALUES (1, 'Timothy', 'Corey', 'TimCorey@gmail.com');
INSERT INTO `people` VALUES (2, 'Jane', 'Simth', 'JSmith@apple.com');
INSERT INTO `people` VALUES (3, 'Sue', 'Storm', 'SueStorm@126.com');
INSERT INTO `people` VALUES (4, 'Bob', 'McClure', 'BobMClu@microsoft.com');
INSERT INTO `people` VALUES (5, 'Mary', 'Jones', 'maryJones@google.com');
INSERT INTO `people` VALUES (6, 'Ray', 'Stone', 'rayStone@163.com');
INSERT INTO `people` VALUES (7, '操', '曹', 'caocao@neusoft.com');
INSERT INTO `people` VALUES (8, '权', '孙', 'sunquan@huawei.com');
INSERT INTO `people` VALUES (9, '备', '刘', 'liubei@qq.com');
INSERT INTO `people` VALUES (10, '飞', '张', 'zhangfen@qq.com');
INSERT INTO `people` VALUES (11, '羽', '关', 'guanyu@qq.com');
INSERT INTO `people` VALUES (12, '亮', '诸葛', 'zhugeliang@qq.com');
INSERT INTO `people` VALUES (13, '郎', '王', 'wanglang@126.com');
INSERT INTO `people` VALUES (14, '肃', '鲁', 'lusu@163.com');
INSERT INTO `people` VALUES (15, '云', '赵', 'zhaoyun@qq.com');
INSERT INTO `people` VALUES (16, '超', '马', 'machao@qq.com');
INSERT INTO `people` VALUES (17, '纯', '马', 'machun@alibaba.com');
INSERT INTO `people` VALUES (18, '万翼', '马', 'mawanyi@qq.com');
INSERT INTO `people` VALUES (19, '禅', '刘', 'liushan@qq.com');
INSERT INTO `people` VALUES (20, '懿', '司马', 'simayi@neusoft.com');
INSERT INTO `people` VALUES (21, '昭', '司马', 'simazhao@neusoft.com');
INSERT INTO `people` VALUES (22, '炎', '司马', 'simayan@neusoft.com');
INSERT INTO `people` VALUES (23, '相如', '司马', 'simaxiangru@han.com');
INSERT INTO `people` VALUES (24, '德宗', '司马', 'simadezong@neusoft.com');
INSERT INTO `people` VALUES (25, '峰', '欧阳', 'ouyangfeng@qq.com');
INSERT INTO `people` VALUES (26, '克', '欧阳', 'ouyangke@qq.com');
INSERT INTO `people` VALUES (27, '超风', '梅', 'machaofeng@126.com');
INSERT INTO `people` VALUES (28, '志', '徐', 'xuzhi@gmail.com');
INSERT INTO `people` VALUES (29, '万宗', '毛', 'maowanzong@china.com');
INSERT INTO `people` VALUES (30, '人凤', '毛', 'maorenfeng@taiwan.com');
INSERT INTO `people` VALUES (31, '爱天', '毛', 'maaitian@china.com');
INSERT INTO `people` VALUES (32, '于铭', '毛', 'mayumin@china.com');
INSERT INTO `people` VALUES (33, '科', '孙', 'sunke@china.com');
INSERT INTO `people` VALUES (34, '中山', '孙', 'sunzhongshan@china.com');
INSERT INTO `people` VALUES (35, '世凯', '袁', 'yuanshikai@qing.com');
INSERT INTO `people` VALUES (36, '袁', '立', 'yuanli@gmail.com');
INSERT INTO `people` VALUES (37, '国西', '李', 'liguoxi@ybu.com');
INSERT INTO `people` VALUES (38, '二', '李', 'lier@dangdang.com');
INSERT INTO `people` VALUES (39, '丽丽', '叶', 'yeili@hongkong.com');
INSERT INTO `people` VALUES (40, '婷', '叶', 'yeting@qq.com');
INSERT INTO `people` VALUES (41, '耳父', '陈', 'chenerfu@china.com');
INSERT INTO `people` VALUES (42, '国富', '陈', 'chenguofu@taiwan.com');
INSERT INTO `people` VALUES (43, '立夫', '陈', 'chenlifu@taiwan.com');
INSERT INTO `people` VALUES (44, '诚', '陈', 'chenchen@taiwan.com');
INSERT INTO `people` VALUES (45, '崇禧', '白', 'baichongxi@taiwan.com');
INSERT INTO `people` VALUES (46, '果夫', '陈', 'chengefu@taiwan.com');
INSERT INTO `people` VALUES (47, '美龄', '宋', 'songmeiling@taiwan.com');
INSERT INTO `people` VALUES (48, '庆龄', '宋', 'songqinglin@china.com');
INSERT INTO `people` VALUES (49, '蔼龄', '宋', 'songailing@taiwan.com');
INSERT INTO `people` VALUES (50, '祥熙', '孔', 'kongxiangxi@gmail.com');
INSERT INTO `people` VALUES (51, '仕杰', '宋', 'songshijie@huawei.com');
INSERT INTO `people` VALUES (52, '天赐', '张', 'zhangtianci@huawei.com');
INSERT INTO `people` VALUES (53, '峰', '乔', 'qiaofeng@xiaomi.com');
INSERT INTO `people` VALUES (54, '誉', '段', 'duanyu@gmail.com');
INSERT INTO `people` VALUES (55, '竹', '虚', 'xuzhu@gmail.com');
INSERT INTO `people` VALUES (56, '容复', '慕', 'morongfu@gmail.com');
INSERT INTO `people` VALUES (57, '植', '曹', 'caozhi@neusoft.com');
INSERT INTO `people` VALUES (58, '丕', '曹', 'caopi@neusoft.com');
INSERT INTO `people` VALUES (59, '冲', '曹', 'caochong@neusoft.com');
INSERT INTO `people` VALUES (60, '爽', '曹', 'caoshuang@neusoft.com');
INSERT INTO `people` VALUES (61, '真', '曹', 'caozhen@neusoft.com');
INSERT INTO `people` VALUES (62, '睿', '曹', 'caorui@neusoft.com');
INSERT INTO `people` VALUES (63, '伟庭', '曹', 'caoweiting@neusoft.com');
INSERT INTO `people` VALUES (64, '值', '王', 'wangzhi@sony.com');
INSERT INTO `people` VALUES (65, '双双', '陈', 'chenshuangshuang@gmail.com');
INSERT INTO `people` VALUES (66, '介石', '蒋', 'jiangzhongzhen@taiwan.com');
INSERT INTO `people` VALUES (67, '经国', '蒋', 'jiangjingguo@taiwan.com');
INSERT INTO `people` VALUES (68, '纬国', '蒋', 'jiangweiguo@taiwan.com');
INSERT INTO `people` VALUES (69, '万安', '蒋', 'jiangwanan@taiwan.com');
INSERT INTO `people` VALUES (70, '方良', '蒋', 'jiangfangliang@taiwan.com');
INSERT INTO `people` VALUES (71, '英', '蒋', 'jiangying@china.com');
INSERT INTO `people` VALUES (72, '学森', '钱', 'qianxuesen@china.com');
INSERT INTO `people` VALUES (73, '雪', '林', 'linxue@gmail.com');
INSERT INTO `people` VALUES (74, '国栋', '林', 'linguodong@gmai.com');
INSERT INTO `people` VALUES (75, '万里', '蒋', 'jiangwanli@gmail.com');
INSERT INTO `people` VALUES (76, '勃', '周', 'zhoubo@han.com');
INSERT INTO `people` VALUES (77, '彬彬', '周', 'zhoubinbin@china.com');
INSERT INTO `people` VALUES (78, '德旺', '朱', 'zhudewang@china.com');
INSERT INTO `people` VALUES (79, '正田', '朱', 'zhuzhengtian@gmail.com');
INSERT INTO `people` VALUES (80, '元璋', '朱', 'zhuyuanzhang@ming.com');
INSERT INTO `people` VALUES (81, '允炆', '朱', 'zhuyunwen@ming,com');
INSERT INTO `people` VALUES (82, '标', '朱', 'zhubiao@ming.com');
INSERT INTO `people` VALUES (83, '棣', '朱', 'zhuli@ming.com');
INSERT INTO `people` VALUES (84, '高炽', '朱', 'zhugaochi@ming.com');
INSERT INTO `people` VALUES (85, '高煦', '朱', 'zhugaoxu@ming.com');
INSERT INTO `people` VALUES (86, '瞻基', '朱', 'zhuzhanji@ming.com');
INSERT INTO `people` VALUES (87, '厚照', '朱', 'zhuhouzhao@ming.com');
INSERT INTO `people` VALUES (88, '秀', '刘', 'liuxiu@han.com');
INSERT INTO `people` VALUES (89, '璋', '刘', 'liuzhang@han.com');
INSERT INTO `people` VALUES (90, '莉莉', '刘', 'liulili@han.com');
INSERT INTO `people` VALUES (91, '志', '刘', 'liuzhi@han.com');
INSERT INTO `people` VALUES (92, '屈氂', '刘', 'liuqumao@han.com');
INSERT INTO `people` VALUES (93, '梦', '刘', 'liumeng@han.com');
INSERT INTO `people` VALUES (94, '凤凤', '张', 'zhangfengfeng@126.com');
INSERT INTO `people` VALUES (95, '美丽', '刘', 'liumeili@126.com');
INSERT INTO `people` VALUES (96, '靖', '郭', 'guojing@163.com');
INSERT INTO `people` VALUES (97, '蓉', '黄', 'huangrong@163.com');
INSERT INTO `people` VALUES (98, '芙', '郭', 'guofu@163.com');
INSERT INTO `people` VALUES (99, '襄', '郭', 'guoxiang@163.com');
INSERT INTO `people` VALUES (100, '美美', '郭', 'guomeimei@163.com');
INSERT INTO `people` VALUES (101, '克', '欧阳', 'ouyangke@126.com');
INSERT INTO `people` VALUES (102, '康', '杨', 'yangkang@126.com');
INSERT INTO `people` VALUES (103, '佳伟', '沈', 'shenjiawei@126.com');
INSERT INTO `people` VALUES (104, '逍遥', '李', 'lixiaoyao@gmail.com');
INSERT INTO `people` VALUES (105, '正淳', '段', 'duanzhengchun@gmail.com');
INSERT INTO `people` VALUES (106, '星竹', '李', 'lixingzhu@gmail.com');
INSERT INTO `people` VALUES (107, '紫', '阿', 'azi@163.com');
INSERT INTO `people` VALUES (108, '朱', '阿', 'azhu@163.com');
INSERT INTO `people` VALUES (109, '延庆', '段', 'duanyanqing@gmail.com');
INSERT INTO `people` VALUES (110, '微微', '曹', 'caoweiwei@126.com');
INSERT INTO `people` VALUES (111, '乐天', '何', 'heletian@ybu.com');
INSERT INTO `people` VALUES (112, '晓婷', '何', 'hexiaoting@gmail.com');

SET FOREIGN_KEY_CHECKS = 1;
