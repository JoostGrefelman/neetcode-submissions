class TreeMap {
    private TreeNode _root { get; set; }

    public TreeMap() {
        _root = null;
    }

    public void Insert(int key, int val) {
        //bst
        _root = dfsInsert(_root, key, val);
        
    }

    private TreeNode dfsInsert(TreeNode root, int key, int val) {
        if (root == null) {
            return new TreeNode(key, val);
        }

        if (root.key == key) {
            root.val = val;
            return root;
        }
        else if (key < root.key) {
            root.left = dfsInsert(root.left, key, val);
        }
        else {
            root.right = dfsInsert(root.right, key, val);
        }

        return root;
    }

    private int dfsGet(TreeNode root, int key) {
        if (root == null) {
            return -1;
        }

        if (root.key == key) {
            return root.val;
        }
        else if (key < root.key) {
            return dfsGet(root.left, key);
        }
        else {
            return dfsGet(root.right, key);
        }
    }

    public int Get(int key) {
        return dfsGet(_root, key);
    }

    public int GetMin() {
        var minNode = GetMinNode(_root);
        if(minNode == null) return -1;
        return minNode.val;
    }

    private TreeNode GetMinNode(TreeNode root) {
        if(root == null) return null;

        var cur = root;
        //Console.WriteLine($"GetMin at {cur.key}, {cur.val}");
        while(cur.left != null) {
            cur = cur.left;
            //Console.WriteLine($"Getmin at {cur.key}, {cur.val}");
        }
        return cur;
    }
    public int GetMax() {
        if(_root == null) return -1;

        var cur = _root;
        while(cur.right != null) {
            cur = cur.right;
        }
        return cur.val;
    }

    public void Remove(int key) {
        if(_root == null) return;

        _root = dfsRemove(_root, key);
    }

    private TreeNode dfsRemove(TreeNode root, int key) {
        if(root == null) return null;
        if(key > root.key) {
            root.right = dfsRemove(root.right, key);
        } else if (key < root.key) {
            root.left = dfsRemove(root.left, key);
        } else if (key == root.key) {
            //Console.WriteLine($"Removing {key} with left {root.left?.key} and right {root.right?.key}");
            if(root.left == null) {
                return root.right;
            } else if (root.right == null) {
                return root.left;
            } else {
                var ios = GetMinNode(root.right);
            //    Console.WriteLine($"Inorder successor found at {ios.key} with val {ios.val}");
                root.key = ios.key;
                root.val = ios.val;
                root.right = dfsRemove(root.right, ios.key);
            }
        }
        return root;
    }

    public List<int> GetInorderKeys() {
        var result = new List<int>();
        dfsKeys(_root, result);
        return result;
    }

    private void dfsKeys(TreeNode root, List<int> result) {
        if(root == null) { return; }
        
        dfsKeys(root.left, result);
        result.Add(root.key);
        dfsKeys(root.right, result);
    }

}

public class TreeNode {
    public int key {get;set;}
    public int val {get;set;} 
    public TreeNode left {get;set;}
    public TreeNode right {get;set;}

    public TreeNode(int key, int val, TreeNode left = null, TreeNode right = null) {
        this.key = key;
        this.val = val;
        this.left = left;
        this.right = right;
    }


}

